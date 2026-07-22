clc;
clear all;
close all;

bw=im2gray(imread("cameraman.jpg"));
lvl=graythresh(bw); 
bw=im2bw(bw,lvl);
se = strel('line',11,70);
se1 = strel('square',8); 
bw2 = imopen(bw,se); 
bw3 = imclose(bw,se1); 
subplot(1,3,1), imshow(bw), title('Original');
subplot(1,3,2), imshow(bw2), title('open sonucu');
subplot(1,3,3), imshow(bw3), title('close sonucu');