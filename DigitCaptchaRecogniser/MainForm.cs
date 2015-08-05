using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                sourceImage.Image = ImageHelper.SafeLoadFromFile(imagePath.Text);

                kuwaharaImage.Image = sourceImage.Image
                    .Kuwahara(Properties.Settings.Default.KuwaharaCore)
                    .Kuwahara(Properties.Settings.Default.KuwaharaCore)
                    .Kuwahara(Properties.Settings.Default.KuwaharaCore);

                thresholdImage.Image = sourceImage.Image
                    .Kuwahara(Properties.Settings.Default.KuwaharaCore)
                    .Kuwahara(Properties.Settings.Default.KuwaharaCore)
                    .Threshold(Properties.Settings.Default.Treshold);
                //kuwaharaImage.Image.Save(Path.GetDirectoryName(openImageDialog.FileName) + "test1.png", ImageFormat.Png);
                medianImage.Image = kuwaharaImage.Image.Threshold(Properties.Settings.Default.Treshold);
            }
        }
    }
}
