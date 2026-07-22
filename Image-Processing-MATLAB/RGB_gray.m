clc;
clear all;
close all;

a=imread("r1.tiff");
figure,imshow(a);

R=a(:,:,1);
G=a(:,:,2);
B=a(:,:,3);
figure,
subplot(1,3,1), imshow(R), title('R');
subplot(1,3,2), imshow(G), title('G');
subplot(1,3,3), imshow(B), title('B');

Gri=0.299 * R + 0.587 * G + 0.114 * B;
Gri1= (R +  G + B)/3;
figure,
subplot(1,3,1), imshow(Gri), title('Gri');
subplot(1,3,2), imshow(Gri1), title('Gri1');
