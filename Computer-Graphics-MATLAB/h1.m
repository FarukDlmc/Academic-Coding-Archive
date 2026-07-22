clc;
clear all;
close all;

%x=[2 4;8 4; 8 10;2 10]

hold on
x=[2 2;4 2; 4 4]
fill(x(:,1),x(:,2),'g');
T1=[cosd(90) sind(90); -sind(90) cosd(90)]
T2=[0 -1; -1 0]
T3=T1*T2;
xi1=x*T1;
xi=x*T3
fill(xi1(:,1),xi1(:,2),'y');
fill(xi(:,1),xi(:,2),'r');
axis padded

% axis([0 inf 0 inf])



I=[1 0; 0 1]

s=x*I
m=I*x