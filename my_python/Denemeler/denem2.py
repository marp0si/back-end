'''
aaa=[-25,60,-7,201,-31,10,78,-63,45,-52,65,42+21,-12-1]
aaa1=[]
def sirala(list_deneme):#büyükten küçük
    for i in range(len(list_deneme)):
        aaa1.append(max(list_deneme))
        list_deneme.remove(max(list_deneme))
    print(aaa1,'aaa1')
         
sirala(aaa[:])
aaa.sort()
aaa.reverse()
'''
'''
from time import sleep
from threading import Timer
 
def sleepsort(values):
    sleepsort.result = []
    def add1(x):
        sleepsort.result.append(x)
        print(x)
    mx = values[0]
    for v in values:
        if mx < v: mx = v
        Timer(v, add1, [v]).start()
    sleep(mx+1)
    return sleepsort.result
    print('sleepsort was worked')
x = [3,2,4,-12,5,10,9,-2]
sleepsort(x)
print(x)
x.sort()
x.reverse()
print(x)
'''

'''
if __name__ == '__main__':
    
    if sleepsort(x) == sorted(x):
        print('sleep sort worked for:',x)
    else:
        print('sleep sort FAILED for:',x)    
'''
sinan="Bu cumle 28 karakter var mi?"
sayi=len(sinan)

if sayi==28 or sayi>=len(sinan):## Or-And
    print("Evet 28 karakterdir. ")