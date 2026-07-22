
clear all;
close all;
clc;

a=5;  % tek degisken
b=[1 2 3 4 5 6 7 8 9];% dizi
m=[9 8 7;6 5 4;3 2 1 ];% matris
% matlab index 1 baslar  c ailesi  index 0
X = zeros(100);
Y(1:50,1:200)=5;
C=10*Y-12;
Z=Y(35:45,75:125);
Y(35:45,75:125)=Y(35:45,75:125)*1.2;
t=Y(1,1);
T=Y';
[r s]=size(Y);

satir=Y(35,:);
sutun=Y(:,3);

 b=imread('cameraman.jpg');
 figure, imshow(b,[]);
 [r s c]=size(b);
load('20231027_aa.mat');
save("20231027_aa_v2.mat");
