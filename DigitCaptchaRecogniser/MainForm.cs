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

           System.Drawing.Image[] digits = new System.Drawing.Image[]
           {
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

           finalDigit1.Image = digits[0].RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold);
           finalDigit2.Image = digits[1].RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold);
           finalDigit3.Image = digits[2].RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold);
           finalDigit4.Image = digits[3].RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold);
           finalDigit5.Image = digits[4].RemoveNoise(Properties.Settings.Default.NoiseObjectThreshold); 

            string dirToWrite = Path.GetDirectoryName(path) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(path);

            Directory.CreateDirectory(dirToWrite);

            sourceImage.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "source.png", ImageFormat.Png);
            medianImage.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "median.png", ImageFormat.Png);
            finalDigit1.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "1.png", ImageFormat.Png);
            finalDigit2.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "2.png", ImageFormat.Png);
            finalDigit3.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "3.png", ImageFormat.Png);
            finalDigit4.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "4.png", ImageFormat.Png);
            finalDigit5.Image.Save(dirToWrite + Path.DirectorySeparatorChar + "5.png", ImageFormat.Png);
        }
    }
}
