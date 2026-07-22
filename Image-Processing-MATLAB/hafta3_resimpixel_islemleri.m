
close all;
clear all;
clc;
resim=imread("8.gif");
figure, imshow(resim); title("resmi");
%% matematiksel islemler


resim1=resim-100;
figure, imshow(resim1); title("resmi1");

resim2=resim+100;
figure, imshow(resim2); title("resmi2");

resim3=(resim+resim2)/2;
figure, imshow(resim3); title("resmi3");

resim4=255-resim;
figure, imshow(resim4); title("resmi4");%resmin negatifi
resim5=resim1+resim4;
figure, imshow(resim5); title("resmi5");
%% logaritmik donusum 
c=1;

l1=c*log(double(1+resim));
figure, imshow(l1); title("l1_c_1");

