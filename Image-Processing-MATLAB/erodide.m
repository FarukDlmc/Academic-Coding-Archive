clc;
clear all;
close all;

r=im2gray(imread("cameraman.jpg"));

se = offsetstrel('ball',5,5);
erodedI = imerode(r,se);
figure, imshow(r,[]);
figure, imshow(erodedI,[]);
BW = erodedI < 70;
SE = strel('square', 10);
er2 = imerode(erodedI,SE);
figure, imshow(er2,[]);