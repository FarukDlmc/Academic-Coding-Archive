ust3D();

a(:,1) = [0 1 1 0 0 1 1 0];  
a(:,2) = [0 0 1 1 0 0 1 1];  
a(:,3) = [0 0 0 0 1 1 1 1];  
a(:,4) = [1 1 1 1 1 1 1 1]; 
B3ciz(a,'cyan','black');
b=5;
c=3;
d=2;
r=4;
j=3;k=4;


T=[1 b c 0; 
   d 1 r 0;
   j k 1 0;
   0 0 0 1];
b=a*T;

sonuc=normalizasyon(b);

% Küpün yüzlerini tanımla  
B3ciz(sonuc,'red','black');