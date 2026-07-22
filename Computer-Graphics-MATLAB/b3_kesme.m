func_ust3D();

a(:,1) = [0 1 1 0 0 1 1 0];  
a(:,2) = [0 0 1 1 0 0 1 1];  
a(:,3) = [0 0 0 0 1 1 1 1];  
a(:,4) = [1 1 1 1 1 1 1 1]; 
func_B3ciz(a,'cyan','black');

T=[1 0 0 0; 
   2 1 0 0;
   3 0 1 0;
   0 0 0 1];



% T=[1 t y 0; 
%    p 1 z 0;
%    l 0 1 0;
%    0 0 0 1];
b=a*T;
% Küpün yüzlerini tanımla  
func_B3ciz(b,'red','black');