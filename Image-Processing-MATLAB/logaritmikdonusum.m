
close all;
clear all;
clc;
img = imread('plaka.jpg');  

% Görüntüyü gri tonlamaya çevirin  
grayImg = rgb2gray(img);  

% Gri tonlama görüntüsünün logaritmik dönüşümünü yapın  
c = 255 / log(1 + double(max(grayImg(:)))); % Ölçekleme faktörü  
logImg = c * log(1 + double(grayImg)); % Logaritmik dönüşüm  

% Sonuçları görüntüleyin  
figure;  
subplot(1, 2, 1);  
imshow(grayImg); title('Orijinal Gri Tonlama Görüntü');  

subplot(1, 2, 2);  
imshow(uint8(logImg)); title('Logaritmik Dönüştürülmüş Görüntü');