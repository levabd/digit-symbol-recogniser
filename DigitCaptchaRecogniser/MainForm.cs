using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AForge.Imaging;
using DigitCaptchaRecogniser.Helpers;

namespace DigitCaptchaRecogniser
{
    public partial class MainForm : Form
    {
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

            System.Drawing.Image[] digits = {
                medianImage.Image.Crop(new Rectangle(0, 0, 
                    Properties.Settings.Default.DigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(new Rectangle(Properties.Settings.Default.DigitWidth + 1, 0, 
                    Properties.Settings.Default.DigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(new Rectangle(Properties.Settings.Default.DigitWidth * 2 + 1, 0,
                    Properties.Settings.Default.SecondDigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(new Rectangle(Properties.Settings.Default.DigitWidth * 2 + Properties.Settings.Default.SecondDigitWidth + 1, 0,
                    Properties.Settings.Default.SecondDigitWidth, medianImage.Image.Height)),
                medianImage.Image.Crop(new Rectangle(Properties.Settings.Default.DigitWidth * 2 + Properties.Settings.Default.SecondDigitWidth * 2 + 1, 0,
                    Properties.Settings.Default.SecondDigitWidth, medianImage.Image.Height))
            };

            digit1.Image = digits[0].DisplayNoise(Color.Red, Properties.Settings.Default.NoiseObjectThreshold);
            digit2.Image = digits[1].DisplayNoise(Color.Red, Properties.Settings.Default.NoiseObjectThreshold);
            digit3.Image = digits[2].DisplayNoise(Color.Red, Properties.Settings.Default.NoiseObjectThreshold);
            digit4.Image = digits[3].DisplayNoise(Color.Red, Properties.Settings.Default.NoiseObjectThreshold);
            digit5.Image = digits[4].DisplayNoise(Color.Red, Properties.Settings.Default.NoiseObjectThreshold);

            System.Drawing.Image[] gaussDigits = new System.Drawing.Image[5];
            int digitsCounter = 0;
            foreach (var digit in digits)
            {
                gaussDigits[digitsCounter] = new Bitmap(Properties.Settings.Default.NormalDigitWidth, Properties.Settings.Default.NormalDigitHeight);

                using (Graphics g = Graphics.FromImage(gaussDigits[digitsCounter]))
                {
                    System.Drawing.Image croppedImage = digit.RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold).
                        Crop(new Rectangle(0, digit.Height - Properties.Settings.Default.NormalDigitHeight + Properties.Settings.Default.ImageVerticalBorder * 2,
                            digit.Width, Properties.Settings.Default.NormalDigitHeight - Properties.Settings.Default.ImageVerticalBorder * 2));

                    g.Clear(Color.Black);
                    int x = (gaussDigits[digitsCounter].Width - croppedImage.Width) / 2;
                    int y = (gaussDigits[digitsCounter].Height - croppedImage.Height) / 2;
                    g.DrawImage(croppedImage, x, y);
                }

                digitsCounter++;
            }

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

            contourDigit1.Image = gaussDigit1.Image.Threshold(Properties.Settings.Default.GaussThreshold).
                RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold);
            contourDigit2.Image = gaussDigit2.Image.Threshold(Properties.Settings.Default.GaussThreshold).
                RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold);
            contourDigit3.Image = gaussDigit3.Image.Threshold(Properties.Settings.Default.GaussThreshold).
                RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold);
            contourDigit4.Image = gaussDigit4.Image.Threshold(Properties.Settings.Default.GaussThreshold).
                RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold);
            contourDigit5.Image = gaussDigit5.Image.Threshold(Properties.Settings.Default.GaussThreshold).
                RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold);

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
    }
}
