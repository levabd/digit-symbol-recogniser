# digit-captcha-recogniser
Recognize noised captcha with only digit symbols using C#

#Algorithm

1. Kuwahara with core 2 (2 times in sequence)
2. Threshold with 91-95 value
3. Median filtering
4. Cutting the numbers
5. Remove small objects (area criteria 70)
6. Crop and add border to image
7. Gauss blur (sigma 4 and kernel size 5)
8. Threshold with 110 value
9. Remove small objects (area criteria)
10. Morfology
11. Adaptive Threshold
12. If Longest contour / Second longest contour < 3 select Second longest contour
13. Contour analysis
. Deep Learning neural network


В качестве примера sec056