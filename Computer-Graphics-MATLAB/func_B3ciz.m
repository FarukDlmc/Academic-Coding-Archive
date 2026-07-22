function func_B3ciz(a,r1,r2)

faces = [1 2 3 4; 5 6 7 8; 1 2 6 5; 2 3 7 6; 3 4 8 7; 4 1 5 8];  


patch('Vertices',[a(:,1) a(:,2) a(:,3)], 'Faces', faces, 'FaceColor', r1, 'EdgeColor', r2); 
end