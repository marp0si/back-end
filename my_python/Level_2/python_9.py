'''
def ustalma(num):   
    def üstü(üst):
        return num**üst
    
    return üstü ####    <-----------fonksiyon döndürüldü

iki=ustalma(2)
five=ustalma(5)
print(five(iki(2)))
'''
'''
def main(num):return num+1
def t_main(num1=main(2)):return num1,a  <-------------- fonksiyon parametre oldu
print(t_main())
'''
'''
def toplama(a,b):
    return a+b
def cikarma(a,b):
    return a-b
def carpma(a,b):
    return a*b
def bolme(a,b):
    return a/b

def islem(f1, f2, f3, f4, islem_adi):
    if islem_adi== "toplama":
        print(f1(2,3))  <-------------- fonksiyon parametre oldu
    elif islem_adi == "cikarma":
        print(f2(5,3))  <-------------- fonksiyon parametre oldu
    elif islem_adi == "carpma":
        print(f3(3,4))  <-------------- fonksiyon parametre oldu
    elif islem_adi == "bolme":
        print(f4(10,2)) <-------------- fonksiyon parametre oldu
    else:
        print("geçersiz işlem...")

islem(toplama, cikarma, carpma, bolme, "toplama")
islem(toplama, cikarma, carpma, bolme, "cikarma")
islem(toplama, cikarma, carpma, bolme, "bolme")
islem(toplama, cikarma, carpma, bolme, "carpma")
islem(toplama, cikarma, carpma, bolme, "carpmaa")
'''
'''
def yetki_sorgula(page):
    def inner(role):
        if role == 'Admin':
            return "{0} rolü {1} sayfasına ulaşabilir.".format(role,page)
        else:
            return "{0} rolü {1} sayfasına ulaşamaz.".format(role,page)
    return inner

user1 = yetki_sorgula("Product Edit")
print(user1("Admin"))   <-----------fonksiyon döndürüldü
print(user1("User"))    <-----------fonksiyon döndürüldü
'''
####################### decorators ################
import math
import time

def calculate_time(func):
    def inner(*args,**kwargs):        
        start = time.time()
        time.sleep(1)
        func(*args,**kwargs)        
        finish = time.time()
        print("fonksiyon "+func.__name__ +" " + str(finish-start) + " saniye sürdü.")
    return inner

@calculate_time
def usalma(a,b):
    print(math.pow(a,b))   

@calculate_time
def faktoriyel(num):
    print(math.factorial(num))

@calculate_time
def toplama(a,b):
    print(a+b)

usalma(2,3)
faktoriyel(4)
toplama(10,20)