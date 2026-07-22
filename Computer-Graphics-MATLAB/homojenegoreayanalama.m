func_ust()
n=[2 4 1; 4 6 1; 2 6 1];
func_sekilc(n,'r');
%0 2 1
d=[-4 0 1 ;6 5 1];
func_dogc(d,'b');

% nokta=[2 2 1];
% %fill(n(:,1), n(:,2), 'r*'); % Dolu üçgen
%  scatter(nokta(:,1,:),nokta(:,2,:),"filled");% nokta gosterimi icin
% %axis equal; % Eşit oranlı bir ekseni etkinleştir
% title('nokta goster');
T1=[ 1  0  0 ; 
     0  1  0 ;
     0  -2  1];% 2 2 den 0 0 oteleme

dT1=d*T1;
% func_dogc(dT1,'r');


nT1=n*T1;
% func_sekilc(nT1,'c');

T2=[(2/sqrt(5)) (-1/sqrt(5)) 0; 
    (1/sqrt(5)) (2/sqrt(5)) 0;
     0            0   1];

dT2=dT1*T2;
% func_dogc(dT2,'y');


nT2=nT1*T2;
% func_sekilc(nT2,'y');


T3=[ 1  0   0 ; 
     0  -1  0 ;
     0  0   1];% 2 2 den 0 0 oteleme


nT3=nT2*T3;
% func_sekilc(nT3,'r');

T4=[(2/sqrt(5)) (1/sqrt(5)) 0; 
    (-1/sqrt(5)) (2/sqrt(5)) 0;
     0            0   1];

nT4=nT3*T4;
% func_sekilc(nT4,'r');


T5=[ 1  0  0 ; 
     0  1  0 ;
     0  2  1];% 0 2 den 0 0 oteleme

nT5=nT4*T5;
func_sekilc(nT5,'r');


