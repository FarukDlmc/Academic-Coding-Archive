close all;
clear all;
clc;
inputImage = imread('8.gif');  
 

% Görüntüyü normalize et  
normalizedImage = double(inputImage) / 255;  
for i=1:0.5:5
% Gama değeri  
gamma = i; % Örneğin, gamma değeri 2.2  

% Gama dönüşümünü uygulayın  
correctedImage = normalizedImage .^ gamma;  

% Çıktıyı normalize et  
correctedImage = uint8(correctedImage * 255); % 0-255 aralığına getir  

% Sonuçları gösterin  
figure;  
subplot(1, 2, 1);  
imshow(inputImage);  
title('Orijinal Görüntü');  

subplot(1, 2, 2);  
imshow(correctedImage);  
title(['Gama Dönüşümü (γ = ' num2str(gamma) ')']);  
end