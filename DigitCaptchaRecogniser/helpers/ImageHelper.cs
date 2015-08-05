using System;
using System.Drawing;

namespace DigitCaptchaRecogniser.Helpers
{
    public static class ImageHelper
    {
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