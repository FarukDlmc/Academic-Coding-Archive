func_ust3D();

a(:,1) = [0 1 1 0 0 1 1 0];  
a(:,2) = [0 0 1 1 0 0 1 1];  
a(:,3) = [0 0 0 0 1 1 1 1];  
a(:,4) = [1 1 1 1 1 1 1 1]; 
func_B3ciz(a,'cyan','black');

xgore=dondur('x', 30);
ygore=dondur('y', 90);
zgore=dondur('z', 60);

% s1=a*xgore;
% func_B3ciz(s1,'yellow','black');
% s2=a*ygore;
% func_B3ciz(s2,'green','black');
% s3=a*zgore;
% func_B3ciz(s3,'black','black');

% T=[1 b c 0; ms
%    d 1 r 0;
%    j k 1 0;
%    0 0 0 1];
b=a*xgore*ygore*zgore;

sonuc=normalizasyon(b);

% Küpün yüzlerini tanımla  
func_B3ciz(sonuc,'red','black');