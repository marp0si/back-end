#object oriented programming
#class:

class Person:
    #-pass
    #attributes
        
        #class attributes
        address='no located'
        #constructor(yapıcı metod)
        def __init__(self,name,year):
            self.names=name
            self.years=year
            print('init calıştı')

        def __str__(self):
            return ''
        
        def __len__(self):
            return self.years

        def __del__(self):
            print(self.names+' obje uzantısı silindi')

        #object attributes
        def changeAddress(self,address):
            self.address=address
       
      
    #method

#object

p1=Person('asd',20)
p2=Person('dsa',10)
p3=Person('aaa',11)#init çalıştırır kappa

#print(p1)
#print(type(p1))
print('name:'+p1.names+'  year:'+str(p1.years))
print('name:'+p2.names+'  year:'+str(p2.years))

print(p1.address)
p1.changeAddress('aaabbbcccc')
print(p1.address)
print(f'{str(p1)} str fonksiyonu çalıştı')
print(f'{len(p1)} len fonksiyon çalıştı')

del p1 ### diğerleri de siliyor çünkü program bitiyor ramde boşa yer kaplamasın knk
'''
class Person:
    address='aaa'
    def __init__(self,name,surname,age):
        self.names=name
        self.surnames=surname
        self.ages=age
        print('personel created')    
   
    def __str__(self):
        return ''
        
    def __len__(self):
        return 5

    def __del__(self):
        print(self.names+' => del ile silindi')
        


class Student(Person):
    def __init__(self,name,surname,age,studentnum):
        super().__init__(name,surname,age)
        self.studentnums=studentnum
        print('student created')
    

class teather(Person):
    def __init__(self,name,surname,age,branch):
        super().__init__(name,surname,age)
        self.branchs=branch
        print('teacher created')

person1=Person('aaa','bbb',10)
Student1=Student('aaaa','bbbb',20,30)
teather1=teather('aaaaa','bbbbb',20,'math')
print(person1.names)
print(Student1.names)
print(teather1.names)

del person1
print(f'{str(Student1)} ===> str çalıştı')
print(f'{len(teather1)}           ===> len çalıştı')
'''

'''
class Person:
    address='aaa'
    def __init__(self,name,surname,age):
        self.names=name
        self.surnames=surname
        self.ages=age
        print('personel created')

class Student(Person):
    def __init__(self,name,surname,age,studentnum):
        super().__init__(name,surname,age)
        self.studentnums=studentnum
        print('student created')

class teather(Person):
    def __init__(self,name,surname,age,branch):
        super().__init__(name,surname,age)
        self.branchs=branch
        print('teacher created')


person1=Person('aaa','bbb',10)
Student1=Student('aaaa','bbbb',20,30)
teather1=teather('aaaaa','bbbbb',20,'math')
print(person1.names)
print(Student1.names)
print(teather1.names)
'''


'''
class Daire:
    pi=3.14
    def __init__(self, yarıcap):
        self.yarıcaps=int(yarıcap)
    def dairecevre(self):
        return(f'{2*self.pi*self.yarıcaps} cevresi')
    def dairealan(self):
        return(f'{self.pi*self.yarıcaps**2} alanı ')

   
daireler=[]
daire1=Daire(input('yarıçap girin: '))
daireler.append(daire1)
daire2=Daire(input('yarıçap girin: '))
daireler.append(daire2)
daireler.append(Daire(input('yarıcap girin: ')))

print(f'{len(daireler)} tane')
for a in daireler:
    print(f'{a.dairealan()}+{a.dairecevre()}')

'''