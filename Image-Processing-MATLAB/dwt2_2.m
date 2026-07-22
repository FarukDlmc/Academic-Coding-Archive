clc;
clear all;
close all;

r=im2gray(imread("cameraman.jpg"));
figure, imshow(r,[]);

[cA,cH,cV,cD] = dwt2(r,'haar');
figure, imshow(cA,[]);
figure, imshow(cH,[]);
figure, imshow(cV,[]);
figure, imshow(cD,[]);

x = idwt2(cA,cH,cV,cD,'haar');
figure, imshow(x,[]);
