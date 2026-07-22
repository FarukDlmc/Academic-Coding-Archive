clc;
clear all;
close all;
a=imread("plaka.jpg");
figure,imshow(a);
R=a(:,:,1);
G=a(:,:,2);
B=a(:,:,3);
HSV = rgb2ycbcr(a);
RGB1 = ycbcr2rgb(HSV);
figure,imshow(HSV);
figure,imshow(RGB1);

H=HSV(:,:,1);
S=HSV(:,:,2);
V=HSV(:,:,3);
figure,
subplot(1,3,1), imshow(R), title('R');
subplot(1,3,2), imshow(G), title('G');
subplot(1,3,3), imshow(B), title('B');


figure
subplot(1,3,1), imshow(H), title('Y');
subplot(1,3,2), imshow(S), title('Cb');
subplot(1,3,3), imshow(V), title('Cr');