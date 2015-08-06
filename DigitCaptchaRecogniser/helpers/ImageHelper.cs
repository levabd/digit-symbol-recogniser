using System;
using System.Drawing;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using Image = System.Drawing.Image;
using Point = System.Drawing.Point;

namespace DigitCaptchaRecogniser.Helpers
{
    public static class ImageHelper
    {
        private static Bitmap BitmapGrayscale(Image image)
        {
            Grayscale grayScaler = new Grayscale(0.2125, 0.7154, 0.0721);
            return grayScaler.Apply(new Bitmap(image));
        }

        /// <summary>
        /// Load image from file without filetype exception
        /// </summary>
        /// <param name="filename">Name of file</param>
        /// <returns>Loaded image or null otherwise</returns>
        public static Image SafeLoadFromFile(string filename)
        {
            try
            {
                return Image.FromFile(filename);
            }
            catch (OutOfMemoryException)
            {
                //The file does not have a valid image format.
                //-or- GDI+ does not support the pixel format of the file

                return null;
            }
        }

        /// <summary>
        /// Blur image with Gauss
        /// </summary>
        /// <param name="image"></param>
        /// <param name="sigma">Gaussia sigma</param>
        /// <param name="kernelSize">Gaussia kermel</param>
        /// <returns></returns>
        public static Image Gauss(this Image image, double sigma, int kernelSize)
        {
            GaussianBlur blur = new GaussianBlur(sigma, kernelSize);
            return blur.Apply(new Bitmap(image));
        }

        /// <returns>Cropped image</returns>
        public static Image Crop(this Image image, Rectangle rectangle)
        {
            Crop cropper = new Crop(rectangle);
            return cropper.Apply(new Bitmap(image));
        }

        /// <summary>
        /// Binarize image with threshold filter
        /// </summary>
        /// <param name="image"></param>
        /// <param name="threshold">threshold for binarization</param>
        public static Image Threshold(this Image image, byte threshold)
        {
            Threshold thresholdFilter = new Threshold(threshold);
            return thresholdFilter.Apply(BitmapGrayscale(image));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static Image CannyEdges(this Image image)
        {
            CannyEdgeDetector cannyEdge = new CannyEdgeDetector();
            return cannyEdge.Apply(BitmapGrayscale(image));
        }


        /// <summary>
        /// Aforge grayscale
        /// </summary>
        public static Image Grayscale(this Image image)
        {
            Grayscale grayScaler = new Grayscale(0.2125, 0.7154, 0.0721);
            return grayScaler.Apply(new Bitmap(image));
        }

        /// <summary>
        /// Aforge median dilatation morfology with default kernel
        /// </summary>
        public static Image Dilatation(this Image image)
        {
            // default kernel
            var se = new short[,] {  {1, 1, 1},
                                     {1, 1, 1},
                                     {1, 1, 1}  };

            Dilatation dilatationFilter = new Dilatation(se);
            return dilatationFilter.Apply(BitmapGrayscale(image));
        }

        /// <summary>
        /// Aforge median filtration
        /// </summary>
        /// <param name="image"></param>
        /// <param name="core">Median core size</param>
        public static Image Median(this Image image, int core)
        {
            var bitmapImage = new Bitmap(image);
            Median medianFilter = new Median(core);
            medianFilter.ApplyInPlace(bitmapImage);
            return bitmapImage;
        }

        /// <summary>
        /// Display little noise object on image
        /// </summary>
        /// <param name="image"></param>
        /// <param name="fillColor">Color to fill noise bject</param>
        /// <param name="threshold">Threshold for noise oblect area</param>
        public static Image DisplayNoise(this Image image, Color fillColor, int threshold = 100)
        {
            Bitmap bitmapImage = new Bitmap(image);

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

        /// <summary>
        /// Remove little noise object on binary image
        /// </summary>
        /// <param name="image"></param>
        /// <param name="threshold">Threshold for noise oblect area</param>
        public static Image RemoveNoise(this Image image, int threshold = 100)
        {
            Bitmap bitmapImage = new Bitmap(image);


            BlobCounter bc = new BlobCounter(bitmapImage);
            // specify sort order
            bc.ObjectsOrder = ObjectsOrder.Size;
            Blob[] blobs = bc.GetObjectsInformation();


            SolidBrush redBrush = new SolidBrush(Color.Black);
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

        /// <summary>
        /// Implementation of Kuwahara filter. See https://en.wikipedia.org/wiki/Kuwahara_filter
        /// </summary>
        /// <param name="image"></param>
        /// <param name="coreSize">Kuwahara core size</param>
        public static Image Kuwahara(this Image image, int coreSize)
        {
            Bitmap tempBitmap = new Bitmap(image);
            Bitmap newBitmap = new Bitmap(tempBitmap.Width, tempBitmap.Height);
            Graphics newGraphics = Graphics.FromImage(newBitmap);
            newGraphics.DrawImage(tempBitmap, new Rectangle(0, 0, tempBitmap.Width, tempBitmap.Height), new Rectangle(0, 0, tempBitmap.Width, tempBitmap.Height), GraphicsUnit.Pixel);
            newGraphics.Dispose();
            int[] apetureMinX = { -(coreSize / 2), 0, -(coreSize / 2), 0 };
            int[] apetureMaxX = { 0, (coreSize / 2), 0, (coreSize / 2) };
            int[] apetureMinY = { -(coreSize / 2), -(coreSize / 2), 0, 0 };
            int[] apetureMaxY = { 0, 0, (coreSize / 2), (coreSize / 2) };
            for (int x = 0; x < newBitmap.Width; ++x)
            {
                for (int y = 0; y < newBitmap.Height; ++y)
                {
                    int[] rValues = { 0, 0, 0, 0 };
                    int[] gValues = { 0, 0, 0, 0 };
                    int[] bValues = { 0, 0, 0, 0 };
                    int[] numPixels = { 0, 0, 0, 0 };
                    int[] maxRValue = { 0, 0, 0, 0 };
                    int[] maxGValue = { 0, 0, 0, 0 };
                    int[] maxBValue = { 0, 0, 0, 0 };
                    int[] minRValue = { 255, 255, 255, 255 };
                    int[] minGValue = { 255, 255, 255, 255 };
                    int[] minBValue = { 255, 255, 255, 255 };
                    for (int i = 0; i < 4; ++i)
                    {
                        for (int x2 = apetureMinX[i]; x2 < apetureMaxX[i]; ++x2)
                        {
                            int tempX = x + x2;
                            if (tempX >= 0 && tempX < newBitmap.Width)
                            {
                                for (int y2 = apetureMinY[i]; y2 < apetureMaxY[i]; ++y2)
                                {
                                    int tempY = y + y2;
                                    if (tempY >= 0 && tempY < newBitmap.Height)
                                    {
                                        Color tempColor = tempBitmap.GetPixel(tempX, tempY);
                                        rValues[i] += tempColor.R;
                                        gValues[i] += tempColor.G;
                                        bValues[i] += tempColor.B;
                                        if (tempColor.R > maxRValue[i])
                                        {
                                            maxRValue[i] = tempColor.R;
                                        }
                                        else if (tempColor.R < minRValue[i])
                                        {
                                            minRValue[i] = tempColor.R;
                                        }
    
                                        if (tempColor.G > maxGValue[i])
                                        {
                                            maxGValue[i] = tempColor.G;
                                        }
                                        else if (tempColor.G < minGValue[i])
                                        {
                                            minGValue[i] = tempColor.G;
                                        }
    
                                        if (tempColor.B > maxBValue[i])
                                        {
                                            maxBValue[i] = tempColor.B;
                                        }
                                        else if (tempColor.B < minBValue[i])
                                        {
                                            minBValue[i] = tempColor.B;
                                        }
                                        ++numPixels[i];
                                    }
                                }
                            }
                        }
                    }
                    int j = 0;
                    int minDifference = 10000;
                    for (int i = 0; i < 4; ++i)
                    {
                        int currentDifference = (maxRValue[i] - minRValue[i]) + (maxGValue[i] - minGValue[i]) + (maxBValue[i] - minBValue[i]);
                        if (currentDifference < minDifference && numPixels[i] > 0)
                        {
                            j = i;
                            minDifference = currentDifference;
                        }
                    }
    
                    Color meanPixel = Color.FromArgb(rValues[j] / numPixels[j],
                        gValues[j] / numPixels[j],
                        bValues[j] / numPixels[j]);
                    newBitmap.SetPixel(x, y, meanPixel);
                }
            }
            return newBitmap;
        }
    }
}