clc;
clear all;
close all;

r=im2gray(imread("cameraman.jpg"));
% figure, imshow(r,[]);
f=fft2(r);
cf=fftshift(f);
figure, imshow(mat2gray(log(1+abs(f))));
figure, imshow(mat2gray(log(1+abs(cf))));

[x,y]=meshgrid(-324:323,-324:323);
 z=sqrt(x.^2+y.^2);
 c=(z<70);
 cf1=cf.*c;
figure, imshow(mat2gray(log(1+abs(cf1))));
s=ifft2(cf1);
figure, imshow(mat2gray((1+abs(s))));

