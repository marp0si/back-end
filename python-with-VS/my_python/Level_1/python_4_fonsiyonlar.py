
import random
max,min,T_bolündügünde1Kalan,tane=50,0,2,3
list1=range(10)
print(str(random.random()))# 0 <= n < 1.0 
print(str(random.randint(0,100)))
print(str(random.sample(range(50),tane)))
print(str(random.randrange(min,max,T_bolündügünde1Kalan)))
print(str(random.choice(list1)))

############################################################

def change1(n):
    n='ada'

name='yigit'
change1(name)
print(name)

def change(n):
    n[0]='istanbul'
sehirler=['ankara','izmir']
change(sehirler)
print(sehirler)


sehirler=['ankara','izmir']
n=sehirler[::]#slince
n[0]='istanbul'
print(n)
print(sehirler)

def add(*param):
    print(type(param))
    top=sum((param))
    print(str(param)+"="+str(top))

add(10,30,45,70,83,10,5)


def myfunc(a,b,*agrs,**kwargs):
    print(a)
    print(b)
    print(agrs)
    print(kwargs)

myfunc(10,20,30,40,50,key1 = 'value1',key = 'value2')
my={"ad":10,"soyad":10 }
print(my)
'''
def square(num): 
    return num**2

a=square(10)
liste=range(10)
b=map(square,liste)
print(list(b))


'''
def square(num):
    return num**2
numbers=[1,3,5,9]
result=list(map(square,numbers))
print(result)
result=list(map(lambda num:num**2,numbers))
print(result)


#for a in numbers:
#    b=square(a)
#    print(b)

#square=lambda num:num**2
print(square(5))