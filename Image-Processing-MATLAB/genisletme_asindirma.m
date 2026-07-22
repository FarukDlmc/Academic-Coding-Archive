clc;
clear all;
close all;

bw=im2gray(imread("cameraman.jpg"));
lvl=graythresh(bw); 
bw=im2bw(bw,lvl);
se = strel('line',11,70);
se1 = strel('square',8); 
bw2 = imdilate(bw,se); 
bw3 = imerode(bw,se1); 
bw2 = imopen(bw,se); 
bw3 = imclose(bw,se1); 
subplot(1,6,1), imshow(bw), title('Original');
subplot(1,6,2), imshow(bw2), title('open sonucu');
subplot(1,6,3), imshow(bw3), title('close sonucu');
subplot(1,6,4), imshow(bw), title('Original');
subplot(1,6,5), imshow(bw2), title('Dilate sonucu');
subplot(1,6,6), imshow(bw3), title('erode sonucu');
