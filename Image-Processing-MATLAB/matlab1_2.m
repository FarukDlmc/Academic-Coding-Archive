clear all;
close all;
clc;

 b=imread('cameraman.png');
 k=b(150:175,75:125,3); 
 k=b(:,51,2);
 %(:,:,1) 1 birinci 
 % matrisi gosterir resimde
 % Red kirmizi renk kanali
 % (:,:,2) 2. matrisi resimde 
 % Green yesil renk kanlini gosterir
 % (:,:,3) 3. matrisi resimde 
 % Blue mavi renk kanlini gosterir
X = [1 0 2; -1 5 0; 0 3 -9];
Y = inv(X);
a=Y*X;

R = randi(255,50);
G = randi(255,50);
B = randi(255,50);
resim=uint8(cat(3,R,G,B));
figure,imshow(resim,[]);
% bir pixel gray level icin 8 bit
% 0-255
% renkli  8x3 24 bit
% 8 biti kirmizi
% 8 biti yesil
% 8 biti mavi
R(:,49)=R(:,49)*2;

xlswrite("deneme.xls",R);%ecxel aktar
num = xlsread("deneme.xls")%veri oku aktar
%X2(:)=bitset(X(:),1,S(:));
% d = bitget(b,1);
