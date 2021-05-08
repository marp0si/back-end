'''
liste=[0,1,2,3,4]
liste_iter=iter(liste)
print(next(liste_iter))#iter yatarrığımız için sırayla gider
print(next(liste_iter))
print(next(liste_iter))
print(next(liste_iter))
print(next(iter(liste)))#yeni iter yaratıyo baştan başlar
print(next(iter(liste)))
print(next(iter(liste)))
'''
# while True:
#     try:
#         element = next(iterator)
#         print(element)
#     except StopIteration:
#         break

# for i in liste:
#     print(i)

'''
class MyNumbers:
    def __init__(self, start, stop):
        self.start = start
        self.stop = stop
        self.empty=0
        if start>stop:
            self.empty=self.start
            self.start=self.stop
            self.stop=self.empty
            
    def __iter__(self):
        return self

    def __next__(self):
        if self.start <= self.stop:
            x = self.start
            self.start += 1
            return x
        else:
            raise StopIteration

list1 = MyNumbers(50,10)

myiter = iter(list1)

# print(next(myiter))
# print(next(myiter))

while True:
    try:
        element = next(myiter)
        print(element,end='-')
    except StopIteration:
        break

'''
#10-11-12-13-14-15-16-17-18-19-20-21-22-23-24-25-
#26-27-28-29-30-31-32-33-34-35-36-37-38-39-40-41-
#42-43-44-45-46-47-48-49-50-

'''
def cube():
    for i in range(5):
        yield i ** 3 ##<--------- yield bellekte yer tutmayan veriler gönderir.

for i in cube():
    print(i)

generator = (i**3 for i in range(5))
print(generator)

for i in generator:
    print(i)
print(next(generator))
print(next(generator))
print(next(generator))
#<generator object <genexpr> at 0x000001C67595F510>
#0
#1
#8
#27
#64
'''