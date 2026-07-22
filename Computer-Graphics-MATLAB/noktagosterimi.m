B2();
%% belirtilen noktalari gosterme


n=[2 2;4 2; 4 4;5 6]

%fill(n(:,1), n(:,2), 'r*'); % Dolu üçgen
 scatter(n(:,1),n(:,2),"filled");% nokta gosterimi icin
%axis equal; % Eşit oranlı bir ekseni etkinleştir
title('nokta goster');