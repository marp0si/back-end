############################## hatalar(errors)/exception ################
'''
print('2 sayıyı bölme')
try:
    x=int(input('x: '))
    y=int(input('y: '))
    if x/y>int(x/y):
        print((x/y))
    else :
        print(int(x/y))
    
except ZeroDivisionError:
    print('0 mu oky knk')
except ValueError:
    print('knk sayı gircen be')

'''
''' 
Below is some common exceptions errors in Python:
IOError
If the file cannot be opened.

ImportError
If python cannot find the module

ValueError
Raised when a built-in operation or function receives an argument that has the
right type but an inappropriate value

KeyboardInterrupt
Raised when the user hits the interrupt key (normally Control-C or Delete)

EOFError
Raised when one of the built-in functions (input() or raw_input()) hits an
end-of-file condition (EOF) without reading any data
'''
######################## Hata oluşturma ################
'''
try:
    import re
    x=int(input('lütfen 10 sayısından küçük bir sayı  girin:'))
    if x>10 or x==10:
       raise Exception("x; 10'ten küçük olsun mu knk")
    elif x<0:
        raise Exception('x: Negatif olmasın lütfen')
except ValueError:
    print ('sayı gir harf değil knk')
except ModuleNotFoundError:
    print('module yok ')

'''
liste=["1","2","5a","10b",'10',"20",'a1',10*20,'2**6']
for a in liste:
    try:
        print(int(a))
    except ValueError or TypeError: 
        pass       
    


#     import re
#     if len(psw) < 8:
#         raise Exception("parola en az 7 karakter olmalıdır.")
#     elif not re.search("[a-z]", psw):
#         raise Exception("parola küçük harf içermelidir.") 
#     elif not re.search("[A-Z]", psw):
#         raise Exception("parola büyük harf içermelidir.")
#     elif not re.search("[0-9]", psw):
#         raise Exception("parola rakam içermelidir.")
#     elif not re.search("[_@$]", psw):
#         raise Exception("parola alpha numeric karakter içermelidir.")
#     elif re.search("\s",psw):
#         raise Exception("parola boşluk içermemelidir.")
#     else:
#         print("geçerli parola")


# password = "1234567aA_"
# try:
#     check_password(password)
# except Exception as ex:
#     print(ex)
# else:
#     print("geçerli parola: else")
# finally:
#     print("validation tamamlandı.")
