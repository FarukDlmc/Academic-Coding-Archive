clc;
clear all;
close all;

r=im2gray(imread("cameraman.jpg"));
se = offsetstrel('ball',5,5);
erodedI = imdilate(r,se);
figure, imshow(r,[]);
figure, imshow(erodedI,[]);