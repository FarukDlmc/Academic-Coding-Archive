clear all;
clc;
close all;
% x=[1 2 3 4];
% y=[0 1 0 1];
% line(x,y);
axis([0 5 0 5]);
grid on;

%P(t)=〖(1-t)〗^3 [1 1]+3(1-t)^2 t[2 3]+3(1-t)t^2 [4 3]+t^3 [3 1]
adim=0.0001;
t=0:adim:1;
for k=1:1:length(t)
 x(k)=(1-t(k))^3+6*t(k)*(1-t(k))^2+12*t(k)^2*(1-t(k))+3*t(k)^3;
 y(k)=(1-t(k))^3+9*t(k)*(1-t(k))^2+9*t(k)^2*(1-t(k))+1*t(k)^3;
end
line(x,y);