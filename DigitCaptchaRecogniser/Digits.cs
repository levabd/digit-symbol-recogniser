using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using ContourAnalysisNS;
using DigitCaptchaRecogniser.Helpers;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Image = System.Drawing.Image;

namespace DigitCaptchaRecogniser
{
    public class CaptchaDigit
    {
        private int _cifre;
        private Image _digit;
        private Image _filledContour;
        private bool _recognised;
        private Contour<Point> _contour;
        private Template _contourTemplate;

        public int Cifre
        {
            get { return _cifre; }
        }

        public Image Digit
        {
            get { return _digit; }
        }

        public bool Recognised
        {
            get { return _recognised; }
        }
        
        public Contour<Point> Contour
        {
            get { return _contour; }
        }

        public Template ContourTemplate
        {
            get { return _contourTemplate; }
        }

        public Image FilledContour
        {
            get { return _filledContour; }
        }

        public int NormalDigitWidth { get; set; }

        public int NormalDigitHeight { get; set; }

        public Histogram DigitHistogram()
        {
            Grayscale grayScaler = new Grayscale(0.2125, 0.7154, 0.0721);
            ImageStatistics stat = new ImageStatistics(grayScaler.Apply(new Bitmap(_digit)));
            return stat.Gray;
        }

        public CaptchaDigit(Image image)
        {
            _cifre = -1;
            _digit = image;
            _recognised = false;
        }

        public void Kuwahara(int kuwaharaCore)
        {
            _digit = _digit.Kuwahara(kuwaharaCore).Kuwahara(kuwaharaCore);
        }

        public void HitAndMiss()
        {
            var se = new short[,] { { -1, -1, -1 },
                                    {  1,  1,  0 },
                                    { -1, -1, -1 } };

            HitAndMiss filter = new HitAndMiss(se, AForge.Imaging.Filters.HitAndMiss.Modes.Thinning);
            Grayscale grayScaler = new Grayscale(0.2125, 0.7154, 0.0721);
            _digit = filter.Apply(grayScaler.Apply(new Bitmap(_digit)));
        }

        public void Dilatate()
        {
            var se = new short[,] {  {1, 1, 1},
                                     {1, 1, 1},
                                     {1, 1, 1}  };

            Grayscale grayScaler = new Grayscale(0.2125, 0.7154, 0.0721);
            Dilatation dilatationFilter = new Dilatation(se);
            _digit = dilatationFilter.Apply(grayScaler.Apply(new Bitmap(_digit)));
        }

        public void ClosingMorfology()
        {
            Grayscale grayScaler = new Grayscale(0.2125, 0.7154, 0.0721);
            Closing closingFilter = new Closing();
            _digit = closingFilter.Apply(grayScaler.Apply(new Bitmap(_digit)));
        }

        public void Threshold(byte threshold)
        {
            _digit = _digit.Grayscale().Threshold(threshold);
        }

        public void ThresholdContour(byte threshold)
        {
            _filledContour = _filledContour.Grayscale().Threshold(threshold);
        }

        /// <summary>
        /// Display little noise object on image
        /// </summary>
        /// <param name="fillColor">Color to fill noise bject</param>
        /// <param name="threshold">Threshold for noise oblect area</param>
        public Image DisplayNoise(Color fillColor, int threshold = 100)
        {
            Bitmap bitmapImage = new Bitmap(_digit);

            BlobCounter bc = new BlobCounter(bitmapImage);
            // specify sort order
            bc.ObjectsOrder = ObjectsOrder.Size;
            Blob[] blobs = bc.GetObjectsInformation();

            SolidBrush redBrush = new SolidBrush(fillColor);
            using (Graphics digit1Graph = Graphics.FromImage(bitmapImage))
            {
                foreach (Blob blob in blobs)
                {
                    if (blob.Area < threshold)
                        digit1Graph.FillRectangle(redBrush, blob.Rectangle);
                }
            }

            return bitmapImage;
        }

        public Image DisplayDigitHistogram(Color fillColor)
        {
            int histHeight = 128;
            Bitmap img = new Bitmap(256, histHeight + 10);
            using (Graphics g = Graphics.FromImage(img))
            {
                for (int i = 0; i < DigitHistogram().Values.Length; i++)
                {
                    float pct = DigitHistogram().Values[i] / DigitHistogram().Values.Max();
                    g.DrawLine(new Pen(fillColor),
                        new Point(i, img.Height - 5),
                        new Point(i, img.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                        );
                }
            }

            return img;
        }

        public Image DisplayAllContours(ImageProcessor processor, Color maxContourColor, Color secondMaxContourColor, Color baseContourColor)
        {
            Image resultDigit = new Bitmap(_digit);
            processor.ProcessImage(new Image<Bgr, Byte>(new Bitmap(resultDigit)), true);
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
                            digitGraph.DrawLines(new Pen(maxContourColor), processor.contours[contourIndex].ToArray());
                        }
                        else if (contourIndex == secondLongestContourIndex)
                        {
                            digitGraph.DrawLines(new Pen(secondMaxContourColor), processor.contours[contourIndex].ToArray());
                        }
                        else
                        {
                            digitGraph.DrawLines(new Pen(baseContourColor), processor.contours[contourIndex].ToArray());
                        }
                    }
                }
            }

            return resultDigit;
        }

        public Image DisplayContoursCorrelation(int correlationWidth, int correlationHeight)
        {
            Bitmap corr = new Bitmap(correlationWidth, correlationHeight);
            using (Graphics correlationsGraphics = Graphics.FromImage(corr))
            {
                _contourTemplate.Draw(correlationsGraphics, new Rectangle(0, 0,
                    correlationWidth, correlationHeight));
            }
            return corr;
        }

        public Image DisplayAdaptiveThreshold(double adaptiveThresholdParameter, int adaptiveThresholdBlockSize)
        {
            Image<Gray, byte> grayFrame = new Image<Gray, byte>(new Bitmap(_digit));
            //CvInvoke.cvAdaptiveThreshold(grayFrame, grayFrame, 255, ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C, THRESH.CV_THRESH_BINARY,
            //        adaptiveThresholdBlockSize + adaptiveThresholdBlockSize % 2 + 1, adaptiveThresholdParameter);
            CvInvoke.cvAdaptiveThreshold(grayFrame, grayFrame, 255, ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C, THRESH.CV_THRESH_BINARY,
                adaptiveThresholdBlockSize + adaptiveThresholdBlockSize % 2 + 1, adaptiveThresholdParameter);
            //grayFrame._Not();
            return grayFrame.ToBitmap();
        }

        /// <summary>
        /// Remove little noise object on binary image
        /// </summary>
        /// <param name="threshold">Threshold for noise oblect area</param>
        public void RemoveNoise(int threshold = 100)
        {
            BlobCounter bc = new BlobCounter(new Bitmap(_digit));
            // specify sort order
            bc.ObjectsOrder = ObjectsOrder.Size;
            Blob[] blobs = bc.GetObjectsInformation();


            SolidBrush redBrush = new SolidBrush(Color.Black);
            Bitmap tempBitmap = new Bitmap(_digit);
            using (Graphics digitGraph = Graphics.FromImage(tempBitmap))
            {
                foreach (Blob blob in blobs)
                {
                    if (blob.Area < threshold)
                        digitGraph.FillRectangle(redBrush, blob.Rectangle);
                }
            }

            _digit = tempBitmap;
        }

        public void CropDigitAddHeight(int imageVerticalBorder, Color color)
        {
            Image newDigit = new Bitmap(NormalDigitWidth, NormalDigitHeight);

            using (Graphics g = Graphics.FromImage(newDigit))
            {
                Image croppedImage = _digit.Crop(new Rectangle(0,
                    _digit.Height - NormalDigitHeight + imageVerticalBorder * 2,
                    _digit.Width, NormalDigitHeight - imageVerticalBorder * 2));

                g.Clear(color);
                int x = (newDigit.Width - croppedImage.Width) / 2;
                int y = (newDigit.Height - croppedImage.Height) / 2;
                g.DrawImage(croppedImage, x, y);
            }

            _digit = newDigit;
        }

        public void Blur(double gaussSigma, int gaussKernelSize)
        {
            _digit = _digit.Gauss(gaussSigma, gaussKernelSize);
        }

        public void AdaptiveThreshold(double adaptiveThresholdParameter, int adaptiveThresholdBlockSize)
        {
            Image<Gray, byte> grayFrame = new Image<Gray, byte>(new Bitmap(_digit));
            //CvInvoke.cvAdaptiveThreshold(grayFrame, grayFrame, 255, ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C, THRESH.CV_THRESH_BINARY,
            //        adaptiveThresholdBlockSize + adaptiveThresholdBlockSize % 2 + 1, adaptiveThresholdParameter);
            CvInvoke.cvAdaptiveThreshold(grayFrame, grayFrame, 255, ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C, THRESH.CV_THRESH_BINARY,
                adaptiveThresholdBlockSize + adaptiveThresholdBlockSize % 2 + 1, adaptiveThresholdParameter);
            //grayFrame._Not();
            _digit = grayFrame.ToBitmap();
        }

        public void FillAllContours(ImageProcessor processor, double owerflowContoursRatio)
        {
            Bitmap newFill = new Bitmap(_digit.Width, _digit.Height);
            using (Graphics contourGraph = Graphics.FromImage(newFill))
            {
                contourGraph.Clear(Color.Black);
            }
 
            processor.ProcessImage(new Image<Bgr, Byte>(new Bitmap(_digit)), true);

            for (int contourCounter = 0; contourCounter < processor.contours.Count; contourCounter++)
            {
                using (Graphics contourGraph = Graphics.FromImage(newFill))
                {
                    contourGraph.FillPolygon(new SolidBrush(Color.White), processor.contours[contourCounter].ToArray());
                }   
            }

            _filledContour = newFill;
        }

        public void MergeContours(double owerflowContoursRatio, double adaptiveThresholdParameter, int adaptiveThresholdBlockSize)
        {
            int secondBiggestContourIndex;
            ImageProcessor processor = new ImageProcessor();
            processor.equalizeHist = false;
            processor.finder.maxRotateAngle = Math.PI / 4;
            processor.minContourArea = 10;
            processor.minContourLength = 15;
            processor.finder.maxACFDescriptorDeviation = 2;
            processor.finder.minACF = 0.96;
            processor.finder.minICF = 0.85;
            processor.blur = false;
            processor.noiseFilter = false;
            processor.cannyThreshold = 50;
            processor.adaptiveThresholdBlockSize = 1;
            processor.adaptiveThresholdParameter = 0.5;

            processor.ProcessImage(new Image<Bgr, Byte>(new Bitmap(_digit)), true);
            if (processor.contours.Count < 3)
            {
                FindBestContour(processor, owerflowContoursRatio);
                FillContour();
                _digit = _filledContour;
                return;
            }

            while (processor.contours.Count > 2)
            {
                AdaptiveThreshold(adaptiveThresholdParameter, adaptiveThresholdBlockSize);
                FillAllContours(processor, owerflowContoursRatio);
                _digit = _filledContour;
                processor.ProcessImage(new Image<Bgr, Byte>(new Bitmap(_digit)), true);
                SortContour(processor, out secondBiggestContourIndex);
                processor.minContourArea = (int)(processor.contours[secondBiggestContourIndex].Area / 4);
                processor.ProcessImage(new Image<Bgr, Byte>(new Bitmap(_digit)), true);
            }
        }

        public void FindBestContour(ImageProcessor processor, double owerflowContoursRatio)
        {
            int secondBiggestContourIndex;
            processor.ProcessImage(new Image<Bgr, Byte>(new Bitmap(_digit)), true);
            var biggestContourIndex = SortContour(processor, out secondBiggestContourIndex);

            if (((biggestContourIndex != secondBiggestContourIndex) &&
                (processor.contours[biggestContourIndex].Area / processor.contours[secondBiggestContourIndex].Area <
                 owerflowContoursRatio)) || (processor.contours.Count < 3))
            {
                _contour = processor.contours[secondBiggestContourIndex];
            }
            else
            {
                _contour = processor.contours[biggestContourIndex];
            }
        }

        public void FindMaxContour(ImageProcessor processor)
        {
            int secondLongestContourIndex;
            processor.ProcessImage(new Image<Bgr, Byte>(new Bitmap(_digit)), true);
            _contour = processor.contours[SortContour(processor, out secondLongestContourIndex)];
        }

        public void FillContour()
        {
            Bitmap newFill = new Bitmap(_digit.Width, _digit.Height);

            using (Graphics contourGraph = Graphics.FromImage(newFill))
            {
                contourGraph.Clear(Color.Black);
                contourGraph.FillPolygon(new SolidBrush(Color.White), _contour.ToArray());
            }

            _filledContour = newFill;
        }

        public void FindTemplate(ImageProcessor processor)
        {
            var contours = new List<Contour<Point>>();
            contours.Add(_contour);
            processor.FindTemplatesNonParalel(contours, true);
            _contourTemplate = processor.samples[0];
        }

        public void Recognise(ImageProcessor processor)
        {
            var contours = new List<Contour<Point>>();
            contours.Add(_contour);
            List<FoundTemplateDesc> recognisedDigits = processor.FindTemplatesNonParalel(contours, true);
            if (recognisedDigits[0] == null)
            {
                _recognised = false;
            }
            else
            {
                _contourTemplate = recognisedDigits[0].template;
                _cifre = recognisedDigits[0].template.name.SafeToInt(-1);
                _recognised = true;
            }
        }

        public void BlurContour(double gaussSigma, int gaussKernelSize)
        {
            _filledContour = _filledContour.Gauss(gaussSigma, gaussKernelSize);
        }

        public void OtsuThreshold()
        {
            _digit = _digit.Grayscale().OtsuThreshold();
        }
        
        public void Median(int kernel)
        {
            _digit = _digit.Median(kernel);
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
    }
}