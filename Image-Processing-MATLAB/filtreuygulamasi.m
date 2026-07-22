close all;
clear all
clc;
img=imread('cameraman.jpg');

filter =(1/40)* [1 8 1;  
                 2 16 2;  
                 1 8 1]; 



filtregoruntusu(:,:,1) = filter2(filter, img(:,:,1), 'same');
filtregoruntusu(:,:,2) = filter2(filter, img(:,:,2), 'same');
filtregoruntusu(:,:,3) = filter2(filter, img(:,:,3), 'same');

figure;  
subplot(1, 2, 1);  
imshow(img);  
title('Orijinal Görüntü');  
subplot(1, 2, 2);  
imshow(uint8(filtregoruntusu));  
title('Filtrelenmiş Görüntü'); 
