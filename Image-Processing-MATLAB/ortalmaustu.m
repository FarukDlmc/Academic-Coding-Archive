%resmin ortalama degeri hesaplayin bu ortalama degerinin altinda 
 %kalanlar 0 ustunde kalanlar1 olacak

 close all;
clear all;
clc;
img = imread('8.gif');  
ort=mean(img(:))
img2=img>=ort;

figure;  
subplot(1, 2, 1);  
imshow(img); title('Orijinal Gri Tonlama Görüntü');  

subplot(1, 2, 2);  
imshow(img2); title('ortalama gore lojik resim');