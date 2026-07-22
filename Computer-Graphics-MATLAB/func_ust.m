function func_ust()
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

end