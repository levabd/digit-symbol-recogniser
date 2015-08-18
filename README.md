# digit-captcha-recogniser
Recognize noised captcha with only digit symbols using C#

#Algorithm

1. Kuwahara with core 2 (2 times in sequence)
2. Median filtering
3. Adaptive Threshold (Otsu) https://en.wikipedia.org/wiki/Otsu%27s_method
4. Cutting the numbers
5. Crop and add border to image
6. Remove small objects (area criteria 25)
7. Morfology
9. If Longest contour / Second longest contour < 3 select Second longest contour
10. Gauss blur (sigma 3 and kernel size 4) of contour
11. Adaptive Threshold (Otsu) of contour https://en.wikipedia.org/wiki/Otsu%27s_method
12. 
13. Contour analysis http://www.codeproject.com/Articles/196168/Contour-Analysis-for-Image-Recognition-in-C Deviation 2


В качестве примера sec056