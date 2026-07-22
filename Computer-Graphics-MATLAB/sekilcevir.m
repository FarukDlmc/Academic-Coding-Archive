ust()
n=[3 -1 1; 4 1 1; 2 1 1];
sekilc(n,'r');

nokta=[2 2 1];
%fill(n(:,1), n(:,2), 'r*'); % Dolu üçgen
 scatter(nokta(:,1,:),nokta(:,2,:),"filled");% nokta gosterimi icin
%axis equal; % Eşit oranlı bir ekseni etkinleştir
title('nokta goster');
T1=[ 1  0  0 ; 
     0  1  0 ;
    -2 -2  1];% 2 2 den 0 0 oteleme

nT1=n*T1;
sekilc(nT1,'c');
T2=[cosd(90) sind(90) 0; 
   -sind(90) cosd(90) 0;
     0            0   1];  %90 derece dondurme donusumu
nT2=nT1*T2;

sekilc(nT2,'g');

T3=[ 1  0  0 ; 
     0  1  0 ;
     2  2  1];

nT3=nT2*T3;

sekilc(nT3,'y');


T=[a b; 
   c d];
N=n*T;
sekilc(N);

T1=[cosd(90) sind(90); -sind(90) cosd(90)]