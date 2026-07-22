% Yeni bir 3D grafik penceresi açın
figure;
grid on;
view(3); % 3D görünümü etkinleştir

% Koordinat sistemi çizimi
plot3([0, 0], [0, 0], [-1, 1], 'k'); % Z ekseni
hold on;
plot3([0, 0], [-1, 1], [0, 0], 'k'); % Y ekseni
plot3([-1, 1], [0, 0], [0, 0], 'k'); % X ekseni

% 3D üçgenin köşe noktalarını belirleyin
x_triangle = [0, 0.5, 1];
y_triangle = [0, 1, 0];
z_triangle = [0, 0, 0];

% 3D üçgeni çizdirin
fill3(x_triangle, y_triangle, z_triangle, 'g'); % Dolu 3D üçgen

% 3D doğru çizimi
x_line = [-1, 1];
y_line = [1, -1];
z_line = [0, 0];
plot3(x_line, y_line, z_line, 'r'); % Kırmızı renkte 3D doğru

axis equal; % Eşit oranlı bir ekseni etkinleştir
title('3D Koordinat Sistemi, Dolu 3D Üçgen ve Kırmızı 3D Doğru');
xlabel('X Ekseni');
ylabel('Y Ekseni');
zlabel('Z Ekseni');