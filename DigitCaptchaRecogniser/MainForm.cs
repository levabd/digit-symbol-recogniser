using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ContourAnalysisNS;
using DigitCaptchaRecogniser.Helpers;

namespace DigitCaptchaRecogniser
{
    public partial class MainForm : Form
    {
        private readonly Properties.Settings _appSettings = Properties.Settings.Default;
        private ImageProcessor _processor;
        private Template[] _templates = new Template[5];

        private PictureBox[] lastContourDigits;
        private PictureBox[] contourDigits;
        private PictureBox[] gaussDigitControlBoxes;
        private PictureBox[] digitBoxes;
        private PictureBox[] correlationBoxes;
        private TextBox[] digitTextBoxes;
        private Label[] templateLabels;

        bool[] recognisedText = { false, false, false, false, false };

        public MainForm()
        {
            InitializeComponent();

            lastContourDigits = new[] { lastContourDigit1, lastContourDigit2, lastContourDigit3, lastContourDigit4, lastContourDigit5 };
            contourDigits = new[] { contourDigit1, contourDigit2, contourDigit3, contourDigit4, contourDigit5 };
            digitBoxes = new[] { digit1, digit2, digit3, digit4, digit5 };
            gaussDigitControlBoxes = new[] { gaussDigit1, gaussDigit2, gaussDigit3, gaussDigit4, gaussDigit5 };
            digitTextBoxes = new[] { digit1Text, digit2Text, digit3Text, digit4Text, digit5Text };
            templateLabels = new[] { Template1Index, Template2Index, Template3Index, Template4Index, Template5Index };
            correlationBoxes = new[] { correlation1, correlation2, correlation3, correlation4, correlation5 };

            InitProcessors();
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

            //sourceImage.Image = sourceImage.Image.Grayscale().Median(0).Threshold(200);

            var digits = sourceImage.Image.ExtractDigits(_appSettings.DigitWidth, _appSettings.SecondDigitWidth);

            try
            {
                textBoxAllDigits.Text = "";
                for (int digitCounter = 0; digitCounter < digits.Count; digitCounter++)
                {
                    digits[digitCounter].NormalDigitWidth = _appSettings.NormalDigitWidth;
                    digits[digitCounter].NormalDigitHeight = _appSettings.NormalDigitHeight;
                    digits[digitCounter].CropDigitAddHeight(_appSettings.ImageVerticalBorder, ColorTranslator.FromHtml("#1B65AA"));
                    digits[digitCounter].Kuwahara(_appSettings.KuwaharaCore);
                    digitBoxes[digitCounter].Image = digits[digitCounter].DisplayNoise(Color.Red, _appSettings.NoiseObjectThreshold);
                    digits[digitCounter].Threshold(_appSettings.Threshold);
                    digits[digitCounter].RemoveNoise(_appSettings.NoiseObjectThreshold);
                    digits[digitCounter].Blur(1, 1);
                    digits[digitCounter].Threshold(120);
                    gaussDigitControlBoxes[digitCounter].Image = digits[digitCounter].Display6890();
                    digits[digitCounter].TryToDetect6890();
                    contourDigits[digitCounter].Image = digits[digitCounter].DisplayAdaptiveThreshold(0.7, 1);
                    digits[digitCounter].MergeContours(_appSettings.ContoursRatio, 0.7, 1);
                    digits[digitCounter].Median(0);
                    lastContourDigits[digitCounter].Image = digits[digitCounter].DisplayAllContours(_processor, Color.Red, Color.GreenYellow, Color.Blue);
                    digits[digitCounter].FindBestContour(_processor, _appSettings.ContoursRatio);
                    digits[digitCounter].FindTemplate(_processor);
                    correlationBoxes[digitCounter].Image = digits[digitCounter].DisplayContoursCorrelation(_appSettings.CorrelationWidth, _appSettings.CorrelationHeight);
                    digits[digitCounter].Recognise(_processor);
                    recognisedText[digitCounter] = digits[digitCounter].Recognised;
                    _templates[digitCounter] = digits[digitCounter].ContourTemplate;
                    digitTextBoxes[digitCounter].Text = digits[digitCounter].Recognised ? digits[digitCounter].Cifre.ToString() : "*";
                    templateLabels[digitCounter].Text = digits[digitCounter].Recognised ? @"Template Index: " + digits[digitCounter].ContourTemplate.index : "";
                    textBoxAllDigits.Text += digitTextBoxes[digitCounter].Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (checkBoxSaveFiles.Checked) 
                PrintImages(path);
        }

        private void buttonTeach_Click(object sender, EventArgs e)
        {
            int[] teachedTexts = new int[5];
            for (int teachedTextCounter = 0; teachedTextCounter < digitTextBoxes.Length; teachedTextCounter++)
                teachedTexts[teachedTextCounter] = (recognisedText[teachedTextCounter]) ? -1 : digitTextBoxes[teachedTextCounter].Text.SafeToInt(-1);
            

            for(int teachedDigitCounter = 0; teachedDigitCounter < teachedTexts.Length; teachedDigitCounter++)
            {
                if (teachedTexts[teachedDigitCounter] > -1)
                {
                    _templates[teachedDigitCounter].name = teachedTexts[teachedDigitCounter].ToString();
                    _processor.templates.Add(_templates[teachedDigitCounter]);
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

            for (int lastContourDigitsCounter = 0;
                lastContourDigitsCounter < lastContourDigits.Length;
                lastContourDigitsCounter++)
            {
                digitBoxes[lastContourDigitsCounter].Image.Save(
                    dirToWrite + Path.DirectorySeparatorChar + "digit" + lastContourDigitsCounter + ".png", ImageFormat.Png);
                gaussDigitControlBoxes[lastContourDigitsCounter].Image.Save(
                    dirToWrite + Path.DirectorySeparatorChar + "gauss" + lastContourDigitsCounter + ".png", ImageFormat.Png);
                contourDigits[lastContourDigitsCounter].Image.Save(
                    dirToWrite + Path.DirectorySeparatorChar + "contour" + lastContourDigitsCounter + ".png", ImageFormat.Png);
                lastContourDigits[lastContourDigitsCounter].Image.Save(
                    dirToWrite + Path.DirectorySeparatorChar + "lastContour" + lastContourDigitsCounter + ".png", ImageFormat.Png);
                correlationBoxes[lastContourDigitsCounter].Image.Save(
                    dirToWrite + Path.DirectorySeparatorChar + "correlation" + lastContourDigitsCounter + ".png", ImageFormat.Png);
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            InitProcessors();
        }

        private void InitProcessors()
        {
            _processor = new ImageProcessor();
            _processor.equalizeHist = false;
            //_processor.finder.maxRotateAngle = differences69.Checked ? Math.PI/49 : Math.PI;
            _processor.finder.maxRotateAngle = differences69.Checked ? _appSettings.MaxAngle : Math.PI;
            _processor.finder.maxRotateAngle = differences17.Checked ? _appSettings.MaxAngleForSeven : Math.PI;
            _processor.minContourArea = _appSettings.MinContourArea;
            _processor.minContourLength = _appSettings.MinContourLength;
            _processor.finder.maxACFDescriptorDeviation = _appSettings.MaxACFDescriptorDeviation; //Auto correlation deviation
            _processor.finder.maxACFNormaDeviation = _appSettings.MaxACFNormaDeviation0; //Auto correlation norma deviation
            _processor.finder.maxACFNormaDeviation0 = _appSettings.MaxACFNormaDeviation0; 
            _processor.finder.maxACFNormaDeviation1 = _appSettings.MaxACFNormaDeviation1; 
            _processor.finder.maxACFNormaDeviation2 = _appSettings.MaxACFNormaDeviation2; 
            _processor.finder.maxACFNormaDeviation3 = _appSettings.MaxACFNormaDeviation3; 
            _processor.finder.maxACFNormaDeviation4 = _appSettings.MaxACFNormaDeviation4; 
            _processor.finder.maxACFNormaDeviation5 = _appSettings.MaxACFNormaDeviation5; 
            _processor.finder.maxACFNormaDeviation6 = _appSettings.MaxACFNormaDeviation6; 
            _processor.finder.maxACFNormaDeviation7 = _appSettings.MaxACFNormaDeviation7; 
            _processor.finder.maxACFNormaDeviation8 = _appSettings.MaxACFNormaDeviation8; 
            _processor.finder.maxACFNormaDeviation9 = _appSettings.MaxACFNormaDeviation9; 
            _processor.finder.minACF = _appSettings.MinACF;
            _processor.finder.minICF = _appSettings.MinICF;
            _processor.blur = false;
            _processor.noiseFilter = false;
            _processor.cannyThreshold = _appSettings.СannyThreshold;
            _processor.adaptiveThresholdBlockSize = _appSettings.AdaptiveThresholdBlockSize;
            _processor.adaptiveThresholdParameter = _appSettings.AdaptiveThresholdParameter; //false ? 1.5 : 0.5;

            LoadTemplates(Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) +
                          Path.DirectorySeparatorChar + _appSettings.TemplatesFile, _processor);
        }

        private void digit5Text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
