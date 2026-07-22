function sonuc=dondur(eksen, aci)

if eksen=='x'
    
sonuc=[1    0          0       0; 
       0 cosd(aci)  sind(aci)  0;
       0 -sind(aci) cosd(aci)  0;
       0    0          0       1];
elseif eksen=='y'

    sonuc=[cosd(aci)    0      -sind(aci)       0; 
           0            1          0            0;
           sind(aci)    0       cosd(aci)       0;
           0            0          0            1];

else
    sonuc=[ cosd(aci)  sind(aci)   0    0;
           -sind(aci)  cosd(aci)   0    0;
            0            0         1    0; 
            0            0         0    1;];
end

end
