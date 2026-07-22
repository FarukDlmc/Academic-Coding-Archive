clc;
clear all;
close all;

r=im2gray(imread("cameraman.jpg"));
figure, imshow(r,[]);

d=dct2(r);
figure, imshow(log(abs(d)),[]);
d(abs(d) > 100) = 0;
figure, imshow(log(abs(d)),[]);
K = idct2(d);
figure, imshow(K,[]);