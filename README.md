# digit-captcha-recogniser
Recognize noised captcha with only digit symbols using C#

#Algorithm

1. Kuwahara with core 2 (2 times in sequence)
2. Threshold with 91-95 value
3. Median filtering
4. Cutting the numbers
5. Crop and add border to image
6. Gauss blur (sigma 4 and kernel size 5)
7. Threshold with 128 value
6. Deep Learning neural network


В качестве примера sec056

sec025 отфильтровать аппендикс
sec046 узкий перешеек