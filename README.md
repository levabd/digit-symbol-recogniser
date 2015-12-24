NOT FOR COMMERTIAL USE!!!
Written only to demonstrate the possibilities of recognition noisy digits

# digit-captcha-recogniser
Recognize noised captcha with only digit symbols using C#

#Algorithm
![](./docPictures/source.png?raw=true)

1. Cutting the numbers
2. Crop and add border to image
3. Kuwahara with core 2 (2 times in sequence)
![](./docPictures/digit0.png?raw=true) ![](./docPictures/digit3.png?raw=true)
4. Threshold
5. Remove small objects (area criteria 25)
![](./docPictures/gauss0.png?raw=true) ![](./docPictures/gauss3.png?raw=true)
6. Gauss blur (sigma 3 and kernel size 4) of contour
7. Threshold
8. If Longest contour / Second longest contour < 3 select Second longest contour
![](./docPictures/contour0.png?raw=true) ![](./docPictures/contour3.png?raw=true)
9. Gauss blur (sigma 3 and kernel size 4) of contour
10. Adaptive Threshold of contour (Canny)
![](./docPictures/lastContour0.png?raw=true) ![](./docPictures/lastContour3.png?raw=true)
11. Contour analysis http://www.codeproject.com/Articles/196168/Contour-Analysis-for-Image-Recognition-in-C Deviation 2
![](./docPictures/correlation0.png?raw=true) ![](./docPictures/correlation3.png?raw=true)


Угол меньше Pi/6.5