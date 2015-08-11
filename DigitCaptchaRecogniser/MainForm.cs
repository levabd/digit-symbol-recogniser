using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ContourAnalysisNS;
using DigitCaptchaRecogniser.Helpers;
using Emgu.CV;
using Emgu.CV.Structure;

namespace DigitCaptchaRecogniser
{
    public partial class MainForm : Form
    {
        private readonly Properties.Settings _appSettings = Properties.Settings.Default;
        private ImageProcessor _processor;
        private Templates _samples;
        int[] recognisedText = { -1, -1, -1, -1, -1 };

        public MainForm()
        {
            InitializeComponent();
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath.Text = openImageDialog.FileName;

                ImageProceed(imagePath.Text);                
            }
        }

        private void imagePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                ImageProceed(imagePath.Text);
        }

        private void ImageProceed(string path)
        {
            try
            {
                sourceImage.Image = ImageHelper.SafeLoadFromFile(path);
            }
            catch (FileNotFoundException)
            {
                return;
            }

            kuwaharaImage.Image = sourceImage.Image.Kuwahara(_appSettings.KuwaharaCore).Kuwahara(_appSettings.KuwaharaCore);

            thresholdImage.Image = kuwaharaImage.Image.Threshold(_appSettings.Treshold);

            medianImage.Image = thresholdImage.Image.Median(0);

            var digits = ExtractDigits();

            DisplayNoise(digits);

            var gaussDigits = RemoveNoiseAndCrop(digits);

            DisplayGauss(gaussDigits);

            digits = new []
            {
                gaussDigit1.Image.Threshold(Properties.Settings.Default.GaussThreshold).RemoveNoise(_appSettings.ContourObjectThreshold),
                gaussDigit2.Image.Threshold(Properties.Settings.Default.GaussThreshold).RemoveNoise(_appSettings.ContourObjectThreshold),
                gaussDigit3.Image.Threshold(Properties.Settings.Default.GaussThreshold).RemoveNoise(_appSettings.ContourObjectThreshold),
                gaussDigit4.Image.Threshold(Properties.Settings.Default.GaussThreshold).RemoveNoise(_appSettings.ContourObjectThreshold),
                gaussDigit5.Image.Threshold(Properties.Settings.Default.GaussThreshold).RemoveNoise(_appSettings.ContourObjectThreshold)
            };

            _processor = new ImageProcessor();
            List<Contour<Point>> contours = new List<Contour<Point>>();

            try
            {
                _processor.equalizeHist = false;
                _processor.finder.maxRotateAngle = differences69.Checked ? Math.PI : Math.PI / 4;
                _processor.minContourArea = _appSettings.MinContourArea;
                _processor.minContourLength = _appSettings.MinContourLength;
                _processor.finder.maxACFDescriptorDeviation = _appSettings.MaxACFDescriptorDeviation; //Auto correlation deviation
                _processor.finder.minACF = _appSettings.MinACF;
                _processor.finder.minICF = _appSettings.MinICF;
                _processor.blur = false;
                _processor.noiseFilter = true;
                _processor.cannyThreshold = _appSettings.СannyThreshold;
                _processor.adaptiveThresholdBlockSize = _appSettings.AdaptiveThresholdBlockSize;
                _processor.adaptiveThresholdParameter = _appSettings.AdaptiveThresholdParameter; //false ? 1.5 : 0.5;

                contours = DisplayContour(_processor, digits);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadTemplates(Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + 
                Path.DirectorySeparatorChar + _appSettings.TemplatesFile, _processor);
            RecogniseDigits(contours, _processor);

            if (checkBoxSaveFiles.Checked) 
                PrintImages(path);
        }

        private void buttonTeach_Click(object sender, EventArgs e)
        {
            int[] teachedTexts =
            {
                (recognisedText[0] < 0) ? digit1Text.Text.SafeToInt(-1) : -1,
                (recognisedText[1] < 0) ? digit2Text.Text.SafeToInt(-1) : -1,
                (recognisedText[2] < 0) ? digit3Text.Text.SafeToInt(-1) : -1, 
                (recognisedText[3] < 0) ? digit4Text.Text.SafeToInt(-1) : -1, 
                (recognisedText[4] < 0) ? digit5Text.Text.SafeToInt(-1) : -1
            };

            for(int teachedDigitCounter = 0; teachedDigitCounter < teachedTexts.Length; teachedDigitCounter++)
            {
                if (teachedTexts[teachedDigitCounter] > -1)
                {
                    _samples[teachedDigitCounter].name = teachedTexts[teachedDigitCounter].ToString();
                    _processor.templates.Add(_samples[teachedDigitCounter]);
                }
            }

            SaveTemplates(Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) +
                Path.DirectorySeparatorChar + _appSettings.TemplatesFile, _processor);
        }

        private void SaveTemplates(string fileName, ImageProcessor proc)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                    new BinaryFormatter().Serialize(fs, proc.templates);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTemplates(string fileName, ImageProcessor proc)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                    proc.templates = (Templates)new BinaryFormatter().Deserialize(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RecogniseDigits(List<Contour<Point>> contours, ImageProcessor proc)
        {
            if (contours.Count > 0)
            {
                List<FoundTemplateDesc> recognisedDigits = proc.FindTemplatesNonParalel(contours);
                _samples = proc.samples;

                Bitmap[] correlations = new Bitmap[5];

                for (int correlationCounter = 0; correlationCounter < correlations.Length; correlationCounter++)
                {
                    correlations[correlationCounter] = new Bitmap(_appSettings.CorrelationWidth, _appSettings.CorrelationHeight);
                    using (Graphics correlationsGraphics = Graphics.FromImage(correlations[correlationCounter]))
                    {
                        _samples[correlationCounter].Draw(correlationsGraphics, new Rectangle(0, 0,
                            _appSettings.CorrelationWidth, _appSettings.CorrelationHeight));
                    }
                }

                correlation1.Image = correlations[0];
                correlation2.Image = correlations[1];
                correlation3.Image = correlations[2];
                correlation4.Image = correlations[3];
                correlation5.Image = correlations[4];

                for(int recognisedDigitCounter = 0; recognisedDigitCounter < recognisedDigits.Count; recognisedDigitCounter++)
                {
                    recognisedText[recognisedDigitCounter] =
                        (recognisedDigits[recognisedDigitCounter] == null) ? -1 : recognisedDigits[recognisedDigitCounter].template.name.SafeToInt(-1);
                }

                digit1Text.Text = (recognisedText[0] < 0) ? "*" : recognisedText[0].ToString();
                digit2Text.Text = (recognisedText[1] < 0) ? "*" : recognisedText[1].ToString();
                digit3Text.Text = (recognisedText[2] < 0) ? "*" : recognisedText[2].ToString();
                digit4Text.Text = (recognisedText[3] < 0) ? "*" : recognisedText[3].ToString();
                digit5Text.Text = (recognisedText[4] < 0) ? "*" : recognisedText[4].ToString();
            }
        }

        private Image[] ExtractDigits()
        {
            Image[] digits =
            {
                medianImage.Image.Crop(new Rectangle(0, 0, _appSettings.DigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(new Rectangle(_appSettings.DigitWidth + 1, 0, _appSettings.DigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(new Rectangle(_appSettings.DigitWidth*2 + 1, 0, _appSettings.SecondDigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(new Rectangle(_appSettings.DigitWidth*2 + _appSettings.SecondDigitWidth + 1, 0, 
                    _appSettings.SecondDigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(new Rectangle(_appSettings.DigitWidth*2 + _appSettings.SecondDigitWidth*2 + 1, 0,
                        _appSettings.SecondDigitWidth, medianImage.Image.Height))
            };
            return digits;
        }

        private void DisplayNoise(Image[] digits)
        {
            digit1.Image = digits[0].DisplayNoise(Color.Red, _appSettings.NoiseObjectThreshold);
            digit2.Image = digits[1].DisplayNoise(Color.Red, _appSettings.NoiseObjectThreshold);
            digit3.Image = digits[2].DisplayNoise(Color.Red, _appSettings.NoiseObjectThreshold);
            digit4.Image = digits[3].DisplayNoise(Color.Red, _appSettings.NoiseObjectThreshold);
            digit5.Image = digits[4].DisplayNoise(Color.Red, _appSettings.NoiseObjectThreshold);
        }

        private Image[] RemoveNoiseAndCrop(Image[] digits)
        {
            int digitsCounter = 0;
            foreach (var digit in digits)
            {
                digits[digitsCounter] = new Bitmap(_appSettings.NormalDigitWidth, _appSettings.NormalDigitHeight);

                using (Graphics g = Graphics.FromImage(digits[digitsCounter]))
                {
                    Image croppedImage = digit.RemoveNoise(_appSettings.NoiseObjectThreshold).
                        Crop(new Rectangle(0, digit.Height - _appSettings.NormalDigitHeight + _appSettings.ImageVerticalBorder * 2, digit.Width,
                            _appSettings.NormalDigitHeight - _appSettings.ImageVerticalBorder * 2));

                    g.Clear(Color.Black);
                    int x = (digits[digitsCounter].Width - croppedImage.Width)/2;
                    int y = (digits[digitsCounter].Height - croppedImage.Height)/2;
                    g.DrawImage(croppedImage, x, y);
                }

                digitsCounter++;
            }
            return digits;
        }

        private void PrintImages(string path)
        {
            string dirToWrite = Path.GetDirectoryName(path) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(path);

            Directory.CreateDirectory(dirToWrite);

            sourceImage.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "source.png", ImageFormat.Png);
            medianImage.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "median.png", ImageFormat.Png);
            lastContourDigit1.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "1.png", ImageFormat.Png);
            lastContourDigit2.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "2.png", ImageFormat.Png);
            lastContourDigit3.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "3.png", ImageFormat.Png);
            lastContourDigit4.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "4.png", ImageFormat.Png);
            lastContourDigit5.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "5.png", ImageFormat.Png);
        }

        private void DisplayGauss(Image[] gaussDigits)
        {
            gaussDigit1.Image = gaussDigits[0].Gauss(_appSettings.GaussSigma, _appSettings.GaussKernelSize);
            gaussDigit2.Image = gaussDigits[1].Gauss(_appSettings.GaussSigma, _appSettings.GaussKernelSize);
            gaussDigit3.Image = gaussDigits[2].Gauss(_appSettings.GaussSigma, _appSettings.GaussKernelSize);
            gaussDigit4.Image = gaussDigits[3].Gauss(_appSettings.GaussSigma, _appSettings.GaussKernelSize);
            gaussDigit5.Image = gaussDigits[4].Gauss(_appSettings.GaussSigma, _appSettings.GaussKernelSize);
        }

        private List<Contour<Point>> DisplayContour(ImageProcessor processor, Image[] digits)
        {
            contourDigit1.Image = DisplayContours(digits[0], processor, true);
            contourDigit2.Image = DisplayContours(digits[1], processor, true);
            contourDigit3.Image = DisplayContours(digits[2], processor, true);
            contourDigit4.Image = DisplayContours(digits[3], processor, true);
            contourDigit5.Image = DisplayContours(digits[4], processor, true);

            List<Contour<Point>> contours = new List<Contour<Point>>
            {
                FindContours(digits[0], processor, true),
                FindContours(digits[1], processor, true),
                FindContours(digits[2], processor, true),
                FindContours(digits[3], processor, true),
                FindContours(digits[4], processor, true)
            };


            lastContourDigit1.Image = digits[0];
            lastContourDigit2.Image = digits[1];
            lastContourDigit3.Image = digits[2];
            lastContourDigit4.Image = digits[3];
            lastContourDigit5.Image = digits[4];

            return contours;
        }

        private Contour<Point> FindContours(Image digit, ImageProcessor processor, bool enableMaxContour)
        {
            int secondLongestContourIndex;
            processor.ProcessImage(new Image<Bgr, Byte>(new Bitmap(digit)), enableMaxContour);
            var longestContourIndex = SortContour(processor, out secondLongestContourIndex);

            using (Graphics digitGraph = Graphics.FromImage(digit))
            {
                if ((longestContourIndex != secondLongestContourIndex) &&
                    (processor.contours[longestContourIndex].Area/processor.contours[secondLongestContourIndex].Area < _appSettings.ContoursRatio))
                {
                    digitGraph.DrawLines(Pens.Red, processor.contours[secondLongestContourIndex].ToArray());
                    return processor.contours[secondLongestContourIndex];
                }

                digitGraph.DrawLines(Pens.Red, processor.contours[longestContourIndex].ToArray());
                return processor.contours[longestContourIndex];
            }
        }

        private int SortContour(ImageProcessor processor, out int secondLongestContourIndex)
        {
            int longestContourIndex = 0;
            secondLongestContourIndex = 0;
            double contourArea = 0;
            for (int contourIndex = 0; contourIndex < processor.contours.Count; contourIndex++)
            {
                if (contourArea < processor.contours[contourIndex].Area)
                {
                    contourArea = processor.contours[contourIndex].Area;
                    secondLongestContourIndex = longestContourIndex;
                    longestContourIndex = contourIndex;
                }
            }
            return longestContourIndex;
        }

        private Image DisplayContours(Image digit, ImageProcessor processor, bool enableMaxContour)
        {
            Image resultDigit = new Bitmap(digit);
            processor.ProcessImage(new Image<Bgr, Byte>(new Bitmap(resultDigit)), enableMaxContour);
            int secondLongestContourIndex;
            var longestContourIndex = SortContour(processor, out secondLongestContourIndex);

            for (int contourIndex = 0; contourIndex < processor.contours.Count; contourIndex++)
            {
                if (processor.contours[contourIndex].Total > 1)
                {
                    using (Graphics digitGraph = Graphics.FromImage(resultDigit))
                    {
                        if (contourIndex == longestContourIndex)
                        {
                            digitGraph.DrawLines(Pens.Red, processor.contours[contourIndex].ToArray());
                        }
                        else if (contourIndex == secondLongestContourIndex)
                        {
                            digitGraph.DrawLines(Pens.GreenYellow, processor.contours[contourIndex].ToArray());
                        }
                        else
                        {
                            digitGraph.DrawLines(Pens.Blue, processor.contours[contourIndex].ToArray());
                        }
                    }
                }                
            }

            return resultDigit;
        }
    }
}
