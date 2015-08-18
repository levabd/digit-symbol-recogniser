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

        private PictureBox[] lastContourDigits;
        private PictureBox[] contourDigits;
        private PictureBox[] gaussDigitControlBoxes;
        private PictureBox[] digitBoxes;
        private PictureBox[] correlationBoxes;
        private TextBox[] digitTextBoxes;
        
        int[] recognisedText = { -1, -1, -1, -1, -1 };

        public MainForm()
        {
            InitializeComponent();

            lastContourDigits = new[] { lastContourDigit1, lastContourDigit2, lastContourDigit3, lastContourDigit4, lastContourDigit5 };
            contourDigits = new[] { contourDigit1, contourDigit2, contourDigit3, contourDigit4, contourDigit5 };
            digitBoxes = new[] { digit1, digit2, digit3, digit4, digit5 };
            gaussDigitControlBoxes = new[] { gaussDigit1, gaussDigit2, gaussDigit3, gaussDigit4, gaussDigit5 };
            digitTextBoxes = new[] { digit1Text, digit2Text, digit3Text, digit4Text, digit5Text };
            correlationBoxes = new[] { correlation1, correlation2, correlation3, correlation4, correlation5 };

            _processor = new ImageProcessor();
            _processor.equalizeHist = false;
            _processor.finder.maxRotateAngle = differences69.Checked ? Math.PI / 4 : Math.PI;
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

            LoadTemplates(Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) +
                Path.DirectorySeparatorChar + _appSettings.TemplatesFile, _processor);
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

            var digits = kuwaharaImage.Image.ExtractDigits(_appSettings.DigitWidth, _appSettings.SecondDigitWidth);

            List<Contour<Point>> contours = new List<Contour<Point>>();

            try
            {
                for (int digitCounter = 0; digitCounter < digits.Count; digitCounter++)
                {
                    digits[digitCounter].NormalDigitWidth = _appSettings.NormalDigitWidth;
                    digits[digitCounter].NormalDigitHeight = _appSettings.NormalDigitHeight;
                    digits[digitCounter].CropDigitAddHeight(_appSettings.ImageVerticalBorder, ColorTranslator.FromHtml("#1B65AA"));
                    digits[digitCounter].Threshold(_appSettings.Threshold);
                    digitBoxes[digitCounter].Image = digits[digitCounter].DisplayNoise(Color.Red, _appSettings.NoiseObjectThreshold);
                    digits[digitCounter].RemoveNoise(_appSettings.NoiseObjectThreshold);
                    digits[digitCounter].Median(0);
                    digits[digitCounter].RemoveNoise(6);
                    digits[digitCounter].Blur(_appSettings.GaussSigma, _appSettings.GaussKernelSize);
                    digits[digitCounter].Threshold(_appSettings.GaussThreshold);
                    digits[digitCounter].Blur(_appSettings.GaussSigma, _appSettings.GaussKernelSize);
                    digits[digitCounter].Threshold(_appSettings.GaussThreshold);
                    gaussDigitControlBoxes[digitCounter].Image = digits[digitCounter].Digit;
                    contourDigits[digitCounter].Image = digits[digitCounter].DisplayAllContours(_processor, Color.Red, Color.GreenYellow, Color.Blue);
                    digits[digitCounter].FindBestContour(_processor, _appSettings.ContoursRatio);
                    digits[digitCounter].FillContour();
                    lastContourDigits[digitCounter].Image = digits[digitCounter].FilledContour;
                    digits[digitCounter].FindTemplate(_processor);
                    correlationBoxes[digitCounter].Image = digits[digitCounter].DisplayContoursCorrelation(_appSettings.CorrelationWidth, _appSettings.CorrelationHeight);
                    digits[digitCounter].Recognise(_processor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //RecogniseDigits(contours, _processor);

            if (checkBoxSaveFiles.Checked) 
                PrintImages(path);
        }

        private void buttonTeach_Click(object sender, EventArgs e)
        {
            int[] teachedTexts = new int[5];
            for (int teachedTextCounter = 0; teachedTextCounter < digitTextBoxes.Length; teachedTextCounter++)
                teachedTexts[teachedTextCounter] = (recognisedText[teachedTextCounter] < 0) ? digitTextBoxes[teachedTextCounter].Text.SafeToInt(-1) : -1;
            

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

        private void PrintImages(string path)
        {
            string dirToWrite = Path.GetDirectoryName(path) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(path);

            Directory.CreateDirectory(dirToWrite);

            sourceImage.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "source.png", ImageFormat.Png);

            for (int lastContourDigitsCounter = 0; lastContourDigitsCounter < lastContourDigits.Length; lastContourDigitsCounter++)
                lastContourDigits[lastContourDigitsCounter].Image.Save(
                    dirToWrite + Path.DirectorySeparatorChar + lastContourDigitsCounter + ".png", ImageFormat.Png);
        }
    }
}
