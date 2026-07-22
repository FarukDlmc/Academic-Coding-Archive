function func_ust3D()
clear all;
close all;
clc;
% Yeni bir 3D grafik penceresi açın
figure;
grid on;
view(3); % 3D görünümü etkinleştir

% Koordinat sistemi çizimi
plot3([0, 0], [0, 0], [-10, 10], 'k'); % Z ekseni
hold on;
plot3([0, 0], [-10, 10], [0, 0], 'k'); % Y ekseni
plot3([-10, 10], [0, 0], [0, 0], 'k'); % X ekseni
hold on;
grid on;
grid minor
set(gca,'xtick',[-10:1:10]);
set(gca,'ytick',[-10:1:10]);
set(gca,'ztick',[-10:1:10]);
axis equal;  % Eşit oranlı bir ekseni etkinleştir
title('3D Koordinat Sistemi, Dolu 3D Üçgen ve Kırmızı 3D Doğru');
xlabel('X Ekseni');
ylabel('Y Ekseni');
zlabel('Z Ekseni');

end