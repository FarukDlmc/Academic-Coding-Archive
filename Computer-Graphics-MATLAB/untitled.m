clear all;
close all;
clc;
figure;
plot([0, 0], [-10, 10], 'k'); % Dikey ekseni çiz
hold on;
grid on;
plot([-10, 10], [0, 0], 'k'); % Yatay ekseni çiz
n=[1 2];
fill(n(1,1), n(1,2), 'r*'); % Dolu üçgen
%axis equal; % Eşit oranlı bir ekseni etkinleştir
title('nokta goster');




x_line = [-1, 1];
y_line = [1, -1];
plot(x_line, y_line, 'r');