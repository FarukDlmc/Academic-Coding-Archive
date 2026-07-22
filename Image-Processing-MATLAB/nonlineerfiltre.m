close all;
clear all
clc;
img=imread('cameraman.jpg');
  noisy_image = imnoise(img, 'salt', 0.05);

filtregoruntusu(:,:,1) = ordfilt2(noisy_image(:,:,1),1,ones(3,3));
filtregoruntusu(:,:,2) = ordfilt2(noisy_image(:,:,2),1,ones(3,3));
filtregoruntusu(:,:,3) = ordfilt2(noisy_image(:,:,3),1,ones(3,3));

figure;  
subplot(1, 3, 1);  
imshow(img);  
title('Orijinal Görüntü');  
subplot(1, 3, 2);  
imshow(noisy_image);  
title('salt and pepper saldirili goruntu Görüntü'); 
subplot(1, 3, 3);  
imshow(uint8(filtregoruntusu));  
title('Filtrelenmiş Görüntü'); 