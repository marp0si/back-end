
import hashlib

sec = input("secin: \n[1] şifrele\n[2] sifre cöz \n")
if sec == '1':
    ifade = input("Şifrelenecek ifadeyi girin: ")
    k = int(input("K faktörünü girin: "))
    print(encode(ifade, k))

elif sec == '2':
    ifade = input("Şifre çözülecek ifadeyi girin: ")
    k = int(input("K faktörünü girin: "))
    print(decode(ifade, k))

    
print(str("Hello, world!".encode(encoding='utf-8')))
