

sehirler=["1.sehir","2.sehir","3.sehir","4.sehir"]

##for sehir in sehirler: print(sehir) 
## for sayi in range(0,11,2): print(sayi)
sayac=0
##while sayac<=10: 
   ## print(sayac) 
    ##sayac=sayac+1

#########################

sayaclar=(1,2,3,4,5)#tuple 
sayac1,sayac2=5,10
def my_function(*sayac):# "*" tuple içinde list "([])"
  for a in range(0,len(sayac[0])):
    print(str(sayac[0][a])+".sinan buradaydi")


#my_function("aaa")

def my_function1(**kid):
  print("His last name is " + kid["lname"])

#my_function1(fname = "Tobias", lname = "Refsnes")

liste1=list(range(5,100,5))
#print(liste1)
greeting="Hello"
#print(list(enumerate(greeting)))
list1=[1,2,3,4]
list2=['a','b','c','d']
#print(list(zip(list1,list2)))

a=range(10)
#print(list(a))#[0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
a=[x**2 for x in range(10) if x%3==0]
#print(list(a))[0, 9, 36, 81]
years=[1965,1991,1997,1998,1968]
ages=[2020-x for x in years]#[55, 29, 23, 22, 52]
#print(list(ages))
my_str="Hello"
my_list=[x for x in my_str]#['H', 'e', 'l', 'l', 'o']
#print(list(my_list))
result=[x if x%2==0 else 'tek' for x in a ]# [0, 'tek', 36, 'tek']
#print(result)
matris=[(x,y) for x in range(3) for y in range(3)]#[(0, 0), (0, 1), (0, 2).....
#print(list(matris))
