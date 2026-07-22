func_ust3D();

a(:,1) = [0 1 1 0 0 1 1 0];  
a(:,2) = [0 0 1 1 0 0 1 1];  
a(:,3) = [0 0 0 0 1 1 1 1];  
a(:,4) = [1 1 1 1 1 1 1 1]; 
func_B3ciz(a,'cyan','black');
x=3;
y=5;
z=4;


T=[1 0 0 0; 
   0 1 0 0;
   0 0 1 0;
   0 0 0 4];
b=a*T;
% func_B3ciz(b,'red','black'); //normalizasyon yapılmamış hali
    
sonuc=normalizasyon(b);

% Küpün yüzlerini tanımla  
func_B3ciz(sonuc,'yellow','black');