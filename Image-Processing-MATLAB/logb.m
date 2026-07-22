function result = logb(x, b)  
    % logb fonksiyonu x'in b tabanında logaritmasını hesaplar  
    if x <= 0  
        error('x pozitif bir sayı olmalıdır.');  
    end  
    if b <= 1  
        error('hata');  
    end  
    result = log(x) / log(b); % Doğal logaritma kullanarak hesaplama  
end 