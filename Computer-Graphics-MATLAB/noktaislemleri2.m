clear all;
close all;
clc;
figure;
plot([0, 0], [-10, 10], 'r'); % Dikey ekseni çiz r burada renk kodudur
hold on;
grid on;
grid minor
set(gca,'xtick',[-10:1:10]);
set(gca,'ytick',[-10:1:10]);
plot([-10, 10], [0, 0], 'r'); % Yatay ekseni çiz

%
n=[2 2;3 4];
 scatter(n(:,1),n(:,2),"filled");
a=1;
b=2;
c=3;
d=1;
T=[a b; c d];
N=n*T;
 scatter(N(1,1),N(1,2),"filled");



