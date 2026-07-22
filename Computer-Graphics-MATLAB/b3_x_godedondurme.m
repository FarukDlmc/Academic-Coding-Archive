ust3D();

a(:,1) = [0 1 1 0 0 1 1 0];  
a(:,2) = [0 0 1 1 0 0 1 1];  
a(:,3) = [0 0 0 0 1 1 1 1];  
a(:,4) = [1 1 1 1 1 1 1 1]; 
B3ciz(a,'cyan','black');
aci=90;
T=[1    0          0       0; 
   0 cosd(aci)  sind(aci)  0;
   0 -sind(aci) cosd(aci)  0;
   0    0          0       1];



% T=[1 t y 0; 
%    p 1 z 0;
%    l 0 1 0;
%    0 0 0 1];
b=a*T;
% Küpün yüzlerini tanımla  
B3ciz(b,'red','black');