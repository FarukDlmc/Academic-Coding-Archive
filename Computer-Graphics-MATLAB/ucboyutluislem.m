ust3D();

a(:,1) = [0 1 1 0 0 1 1 0];  
a(:,2) = [0 0 1 1 0 0 1 1];  
a(:,3) = [0 0 0 0 1 1 1 1];  
a(:,4) = [1 1 1 1 1 1 1 1];  

% Küpün yüzlerini tanımla  
faces = [1 2 3 4; 5 6 7 8; 1 2 6 5; 2 3 7 6; 3 4 8 7; 4 1 5 8];  


patch('Vertices',[a(:,1) a(:,2) a(:,3)], 'Faces', faces, 'FaceColor', 'cyan', 'EdgeColor', 'black'); 