using System;
using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using Image = System.Drawing.Image;

namespace DigitCaptchaRecogniser.Helpers
{
    public static class ImageHelper
    {
        private static Bitmap BitmapGrayscale(Image image)
        {
            Grayscale grayScaler = new Grayscale(0.2125, 0.7154, 0.0721);
            return grayScaler.Apply(new Bitmap(image));
        }

        public static List<CaptchaDigit> ExtractDigits(this Image sourceImage, int DigitWidth, int SecondDigitWidth)
        {
            List<CaptchaDigit> digits = new List<CaptchaDigit>();
            digits.Add(new CaptchaDigit(sourceImage.Crop(new Rectangle(0, 0, DigitWidth, sourceImage.Height))));
            digits.Add(new CaptchaDigit(sourceImage.Crop(new Rectangle(DigitWidth + 1, 0, DigitWidth, sourceImage.Height))));
            digits.Add(new CaptchaDigit(sourceImage.Crop(new Rectangle(DigitWidth * 2 + 1, 0, SecondDigitWidth, sourceImage.Height))));
            digits.Add(new CaptchaDigit(sourceImage.Crop(new Rectangle(DigitWidth * 2 + 25 + 1, 0, SecondDigitWidth, sourceImage.Height))));
            digits.Add(new CaptchaDigit(sourceImage.Crop(new Rectangle(DigitWidth * 2 + SecondDigitWidth + 24 + 1, 0, SecondDigitWidth, sourceImage.Height))));

            return digits;
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

        /// <returns>Cropped image</returns>
        public static Image CropHeight(this Image image, int height, bool fromUp = true)
        {
            Crop cropper = new Crop(new Rectangle(0, fromUp ? 0 : height, image.Width, fromUp ? height : image.Height));
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
        /// Binarize image with SIS threshold filter
        /// </summary>
        /// <param name="image"></param>
        public static Image SISThreshold(this Image image)
        {
            SISThreshold thresholdFilter = new SISThreshold();
            return thresholdFilter.Apply(BitmapGrayscale(image));
        }

        /// <summary>
        /// Binarize image with Otsu threshold filter
        /// </summary>
        /// <param name="image"></param>
        public static Image OtsuThreshold(this Image image)
        {
            OtsuThreshold thresholdFilter = new OtsuThreshold();
            return thresholdFilter.Apply(BitmapGrayscale(image));
        }

        /// <summary>
        /// Binarize image with iterative threshold filter
        /// </summary>
        /// <param name="image"></param>
        /// <param name="threshold">threshold for binarization</param>
        public static Image IterativeThreshold(this Image image, byte threshold)
        {
            IterativeThreshold thresholdFilter = new IterativeThreshold(2, threshold);
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

        public static Histogram GetHistogram(this Image image)
        {
            Grayscale grayScaler = new Grayscale(0.2125, 0.7154, 0.0721);
            ImageStatistics stat = new ImageStatistics(grayScaler.Apply(new Bitmap(image)));
            return stat.Gray;
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

        #region CropUnwantedBackground
        public static Bitmap CropUnwantedBackground(this Image image)
        {
            Bitmap bmp = new Bitmap(image);
            var backColor = GetMatchedBackColor(bmp);
            if (backColor.HasValue)
            {
                var bounds = GetImageBounds(bmp, backColor);
                var diffX = bounds[1].X - bounds[0].X + 1;
                var diffY = bounds[1].Y - bounds[0].Y + 1;
                var croppedBmp = new Bitmap(diffX, diffY);
                var g = Graphics.FromImage(croppedBmp);
                var destRect = new Rectangle(0, 0, croppedBmp.Width, croppedBmp.Height);
                var srcRect = new Rectangle(bounds[0].X, bounds[0].Y, diffX, diffY);
                g.DrawImage(bmp, destRect, srcRect, GraphicsUnit.Pixel);
                return croppedBmp;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Private Methods

        #region GetImageBounds
        private static Point[] GetImageBounds(Bitmap bmp, Color? backColor)
        {
            //--------------------------------------------------------------------
            // Finding the Bounds of Crop Area bu using Unsafe Code and Image Proccesing
            Color c;
            int width = bmp.Width, height = bmp.Height;
            bool upperLeftPointFounded = false;
            var bounds = new Point[2];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    c = bmp.GetPixel(x, y);
                    bool sameAsBackColor = ((c.R <= backColor.Value.R * 1.1 && c.R >= backColor.Value.R * 0.9) &&
                                            (c.G <= backColor.Value.G * 1.1 && c.G >= backColor.Value.G * 0.9) &&
                                            (c.B <= backColor.Value.B * 1.1 && c.B >= backColor.Value.B * 0.9));
                    if (!sameAsBackColor)
                    {
                        if (!upperLeftPointFounded)
                        {
                            bounds[0] = new Point(x, y);
                            bounds[1] = new Point(x, y);
                            upperLeftPointFounded = true;
                        }
                        else
                        {
                            if (x > bounds[1].X)
                                bounds[1].X = x;
                            else if (x < bounds[0].X)
                                bounds[0].X = x;
                            if (y >= bounds[1].Y)
                                bounds[1].Y = y;
                        }
                    }
                }
            }
            return bounds;
        }
        #endregion

        #region GetMatchedBackColor
        private static Color? GetMatchedBackColor(Bitmap bmp)
        {
            // Getting The Background Color by checking Corners of Original Image
            var corners = new Point[]{
            new Point(0, 0),
            new Point(0, bmp.Height - 1),
            new Point(bmp.Width - 1, 0),
            new Point(bmp.Width - 1, bmp.Height - 1)
        }; // four corners (Top, Left), (Top, Right), (Bottom, Left), (Bottom, Right)
            for (int i = 0; i < 4; i++)
            {
                var cornerMatched = 0;
                var backColor = bmp.GetPixel(corners[i].X, corners[i].Y);
                for (int j = 0; j < 4; j++)
                {
                    var cornerColor = bmp.GetPixel(corners[j].X, corners[j].Y);// Check RGB with some offset
                    if ((cornerColor.R <= backColor.R * 1.1 && cornerColor.R >= backColor.R * 0.9) &&
                        (cornerColor.G <= backColor.G * 1.1 && cornerColor.G >= backColor.G * 0.9) &&
                        (cornerColor.B <= backColor.B * 1.1 && cornerColor.B >= backColor.B * 0.9))
                    {
                        cornerMatched++;
                    }
                }
                if (cornerMatched > 2)
                {
                    return backColor;
                }
            }
            return null;
        }
        #endregion

        #endregion
    }
}