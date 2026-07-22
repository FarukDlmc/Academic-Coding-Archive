ust3D();

x_triangle = [0, 1, 1];
y_triangle = [1, 1, 0];
z_triangle = [1, 0, 1];
%plot3(x_triangle,y_triangle,z_triangle);

% 3D üçgeni çizdirin
fill3(x_triangle, y_triangle, z_triangle, 'g'); % Dolu 3D üçgen
axis equal; % Eşit oranlı bir ekseni etkinleştir
title('3D Koordinat Sistemi, Dolu 3D Üçgen ve Kırmızı 3D Doğru');
xlabel('X Ekseni');
ylabel('Y Ekseni');
zlabel('Z Ekseni');