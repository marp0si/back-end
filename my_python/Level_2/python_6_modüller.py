                #1.yöntem
import math,random
#import math as islem



#value=dir(math)
#value=help(math)
#value=help(math.factorial)
#value=math.sqrt(49)#kök
#value=math.factorial(6)#faktöriyel
#value=math.floor(5.9)##(zemin) alta yuvarlar
#value=math.ceil(5.9)##(tavan) üste yuvarlar


#value=islem.ceil(26.56)
#value=islem.factorial(9)


## 2. yöntem

#from math import *
from math import factorial,sqrt,ceil
value=factorial(9)
value=sqrt(9)
value=ceil(6.26)



# result = dir(random)
# result = help(random)

result = random.random() # 0.0 - 1.0
result = random.random() * 100
result = int(random.uniform(10,100))
result = random.randint(1,100)

greeting = 'hello there'
names = ['ali','yağmur','deniz','cenk','ahmet','efe']
# result = names[random.randint(0,len(names)-1)]

result = random.choice(names)
result = random.choice(greeting)

liste = list(range(10))
random.shuffle(liste)
result = liste

liste = range(100)
result = random.sample(liste, 3)
result = random.sample(names, 2)

#print(result)
#print(f"{value} = 6.26'ın üst yuvarlaması" )
###############################
###############################
## main modul ##
number=10
numbers=[0,1,2]

person={"name": "ali",'age':10,'city':'istanbul'}

def fonksiyon(x):
    '''
    mod hakinda bilgiler
    '''
    print(f'x: {x}')



