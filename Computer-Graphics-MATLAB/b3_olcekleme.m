func_ust3D();

a(:,1) = [0 1 1 0 0 1 1 0];  
a(:,2) = [0 0 1 1 0 0 1 1];  
a(:,3) = [0 0 0 0 1 1 1 1];  
a(:,4) = [1 1 1 1 1 1 1 1]; 
func_B3ciz(a,'yellow','black');

T=[1 0 0 0; 
   0 1 0 0;
   0 0 1 0;
   0 0 0 1/3];


% T=[k 0 0 1; 
%    0 l 0 1;
%    0 0 m 1;
%    0 0 0 s];
b=a*T;
% Küpün yüzlerini tanımla  
func_B3ciz(b*3,'red','black');