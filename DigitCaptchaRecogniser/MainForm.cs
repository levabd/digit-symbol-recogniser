using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using ContourAnalysisNS;
using DigitCaptchaRecogniser.Helpers;
using Emgu.CV;
using Emgu.CV.Structure;

namespace DigitCaptchaRecogniser
{
    public partial class MainForm : Form
    {
        ImageProcessor processor;

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
            sourceImage.Image = ImageHelper.SafeLoadFromFile(path);

            kuwaharaImage.Image = sourceImage.Image.Kuwahara(Properties.Settings.Default.KuwaharaCore).Kuwahara(Properties.Settings.Default.KuwaharaCore);

            thresholdImage.Image = kuwaharaImage.Image.Threshold(Properties.Settings.Default.Treshold);

            medianImage.Image = thresholdImage.Image.Median(0);

            var digits = ExtractDigits();

            DisplayNoise(digits);

            var gaussDigits = RemoveNoiseAndCrop(digits);

            DisplayGauss(gaussDigits);

            DisplayContour();

            PrintImages(path);
        }

        private Image[] ExtractDigits()
        {
            Image[] digits =
            {
                medianImage.Image.Crop(new Rectangle(0, 0,
                    Properties.Settings.Default.DigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(new Rectangle(Properties.Settings.Default.DigitWidth + 1, 0,
                    Properties.Settings.Default.DigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(new Rectangle(Properties.Settings.Default.DigitWidth*2 + 1, 0,
                    Properties.Settings.Default.SecondDigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(
                    new Rectangle(Properties.Settings.Default.DigitWidth*2 + Properties.Settings.Default.SecondDigitWidth + 1, 0,
                        Properties.Settings.Default.SecondDigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(
                    new Rectangle(
                        Properties.Settings.Default.DigitWidth*2 + Properties.Settings.Default.SecondDigitWidth*2 + 1, 0,
                        Properties.Settings.Default.SecondDigitWidth, medianImage.Image.Height))
            };
            return digits;
        }

        private void DisplayNoise(Image[] digits)
        {
            digit1.Image = digits[0].DisplayNoise(Color.Red, Properties.Settings.Default.NoiseObjectThreshold);
            digit2.Image = digits[1].DisplayNoise(Color.Red, Properties.Settings.Default.NoiseObjectThreshold);
            digit3.Image = digits[2].DisplayNoise(Color.Red, Properties.Settings.Default.NoiseObjectThreshold);
            digit4.Image = digits[3].DisplayNoise(Color.Red, Properties.Settings.Default.NoiseObjectThreshold);
            digit5.Image = digits[4].DisplayNoise(Color.Red, Properties.Settings.Default.NoiseObjectThreshold);
        }

        private static Image[] RemoveNoiseAndCrop(Image[] digits)
        {
            int digitsCounter = 0;
            foreach (var digit in digits)
            {
                digits[digitsCounter] = new Bitmap(Properties.Settings.Default.NormalDigitWidth,
                    Properties.Settings.Default.NormalDigitHeight);

                using (Graphics g = Graphics.FromImage(digits[digitsCounter]))
                {
                    Image croppedImage = digit.RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold).
                        Crop(new Rectangle(0,
                            digit.Height - Properties.Settings.Default.NormalDigitHeight +
                            Properties.Settings.Default.ImageVerticalBorder*2,
                            digit.Width,
                            Properties.Settings.Default.NormalDigitHeight - Properties.Settings.Default.ImageVerticalBorder*2));

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
            gaussDigit1.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "1.png", ImageFormat.Png);
            gaussDigit2.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "2.png", ImageFormat.Png);
            gaussDigit3.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "3.png", ImageFormat.Png);
            gaussDigit4.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "4.png", ImageFormat.Png);
            gaussDigit5.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "5.png", ImageFormat.Png);
        }

        private void DisplayGauss(Image[] gaussDigits)
        {
            gaussDigit1.Image = gaussDigits[0].
                Gauss(Properties.Settings.Default.GaussSigma, Properties.Settings.Default.GaussKernelSize);
            gaussDigit2.Image = gaussDigits[1].
                Gauss(Properties.Settings.Default.GaussSigma, Properties.Settings.Default.GaussKernelSize);
            gaussDigit3.Image = gaussDigits[2].
                Gauss(Properties.Settings.Default.GaussSigma, Properties.Settings.Default.GaussKernelSize);
            gaussDigit4.Image = gaussDigits[3].
                Gauss(Properties.Settings.Default.GaussSigma, Properties.Settings.Default.GaussKernelSize);
            gaussDigit5.Image = gaussDigits[4].
                Gauss(Properties.Settings.Default.GaussSigma, Properties.Settings.Default.GaussKernelSize);
        }

        private void DisplayContour()
        {
            Image[] digits = new Image[]
            {
                gaussDigit1.Image.Threshold(Properties.Settings.Default.GaussThreshold).
                    RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold),
                gaussDigit2.Image.Threshold(Properties.Settings.Default.GaussThreshold).
                    RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold),
                gaussDigit3.Image.Threshold(Properties.Settings.Default.GaussThreshold).
                    RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold),
                gaussDigit4.Image.Threshold(Properties.Settings.Default.GaussThreshold).
                    RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold),
                gaussDigit5.Image.Threshold(Properties.Settings.Default.GaussThreshold).
                    RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold)
            };

            processor = new ImageProcessor();

            try
            {
                processor.equalizeHist = false;
                processor.finder.maxRotateAngle = 2 * Math.PI; //true ? Math.PI : Math.PI / 4;
                processor.minContourArea = 10;
                processor.minContourLength = 15;
                processor.finder.maxACFDescriptorDeviation = 4;
                processor.finder.minACF = 0.96;
                processor.finder.minICF = 0.85;
                processor.blur = false;
                processor.noiseFilter = true;
                processor.cannyThreshold = 50;
                processor.adaptiveThresholdBlockSize = 6;
                processor.adaptiveThresholdParameter = 1; //false ? 1.5 : 0.5;

                foreach (var digit in digits)
                {
                    if (!findContours(digit, false))
                        findContours(digit, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            contourDigit1.Image = digits[0];
            contourDigit2.Image = digits[1];
            contourDigit3.Image = digits[2];
            contourDigit4.Image = digits[3];
            contourDigit5.Image = digits[4];
        }

        private bool findContours(Image digit, bool enableMaxContour)
        {
            processor.ProcessImage(new Image<Bgr, Byte>(new Bitmap(digit)), enableMaxContour);
            int longestContourIndex = 0;
            double contourArea = 0;
            for (int contourIndex = 0; contourIndex < processor.contours.Count; contourIndex++)
            {
                if (contourArea < processor.contours[contourIndex].Area)
                {
                    contourArea = processor.contours[contourIndex].Area;
                    longestContourIndex = contourIndex;
                }
            }

            if (processor.contours[longestContourIndex].Area < 200)
                return false;

            for (int contourIndex = 0; contourIndex < processor.contours.Count; contourIndex++)
            {
                if (processor.contours[contourIndex].Total > 1)
                {
                    using (Graphics digitGraph = Graphics.FromImage(digit))
                    {
                        if (contourIndex == longestContourIndex)
                            digitGraph.DrawLines(Pens.Red, processor.contours[contourIndex].ToArray());
                        else
                            digitGraph.DrawLines(Pens.Blue, processor.contours[contourIndex].ToArray());
                        
                    }
                }                
            }

            return true;
        }
    }
}
