##my_list=[1,2,3]
##my_list=["bir",2,True,5.2]
##print(my_list)

list1=["one",10,"there"]
list2=["four",20,"six"]
list4=[list1,list2]
#print(list1+list2)
T_sayi=len(list1)+len(list2)
#print(T_sayi)
list3=[list1[0]+list2[0],list1[1]+list2[1]]
##print(list3)
##print(list4[0])
##print(list4[0][2])
##print(list4[0][2][0:4])
##################
tuple1=("asd","asd","asd")#sabit dizi

numbers=[1,2,3,4,5,6,7,8,9,10,5]
letters=["a","b","c","d","e","a"]
ref=max(numbers)
ref=min(numbers)
ref=max(letters)
##print(ref)
ref=min(letters)
##print(ref)
ref=numbers[::-1]
ref=numbers[:4]

numbers.insert(3,78)##3.index'e 78i ekler sonrakileri +1indexlerine atar
numbers.sort() ##diziyi k-->b siralar
numbers.reverse() ## diziyi cevirir
numbers.append(40)##dizinin sonuna 40 elemanini ekler
numbers.pop(3)##default son elemani, icindekise, indexsi siler
numbers.remove(40)## icine yazilan degeri arar ve siler

sayi=numbers.count(5)##icindeki eleman dizide kac tane var 
index=letters.index("b")#icindeki elemanin indexini verir
result="b" in letters #lettersda a elemani var mi 
numbers *=0
#print(numbers)


#asd=raw_input('marka girin= ')
#markalar=[]
#markalar.append("marka")
#print(asd)
##print(ref)
######################### DIC
##ogrenci_no=input("Ogrenci no:")
##ogrenci_ad=input("AD no:")
##ogrenci_soyad=input("Soyad no:")
##ogrenci_tel=input("Telefon no:")
##ogrenci_info=[ogrenci_ad,ogrenci_soyad,ogrenci_tel]##array
##print(ogrenci_info)
#ogrenciler={}##1.step ->tanıt
#ogrenciler[ogrenci_no] ={"ad":ogrenci_ad,"soyad":ogrenci_soyad }##2.step->Deger ata
#print(ogrenciler[ogrenci_no]["ad"])



##################### Set but type(set)="type" ##############
#set1=  {4,   5,     1}#indexsi olmayan
#set1=set1.add(2)
#print(type(set))


#########################date ###############
import datetime
tarih=input("tarih gir(g/a/y):")
tarih=tarih.split("/")
gün=int(tarih[0])
ay=int(tarih[1])
yıl=int(tarih[2])
simdikitarih=datetime.datetime.now()

sontarih=[20,12,2021]
kalanyıl=sontarih[2]-yıl
kalanay=sontarih[1]-ay
kalangün=sontarih[0]-gün
toplamgün=kalanyıl*365+kalanay*30+gün
print(str(kalanyıl) +" yıl")
print(str(kalanay)+" ay")
print(str(kalangün )+" yıl")
print("yani "+str(toplamgün)+" gün var")


print(str(simdikitarih))