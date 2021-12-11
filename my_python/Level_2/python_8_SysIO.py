#open(file.name,'r',encoding='cp1252') (read -okuma) default okur yoksa hata verir
#open('*.*','w',encoding='cp1252') (write-yazma) konumda oluşturur
#open('*.*','a',encoding='cp1252') (append-ekleme) ekler yoksa oluşturur
#open('*.*','x',encoding='cp1252') (create-oluşturma) oluşturur varsa hata
#open('*.*','r+',encoding='cp1252') read and write -güncelleme yaparken
'''
open()
close()
encoding=
write()
read()
readline()
readlines()
tell() imleç nerderse onu söyler
seek()imlecin yerini değiştirir
'''

'''
file=open('Dates_and_times.txt','r')
file=open('new_files.txt','w')
file = open("C:/users/sinan/desktop/newfile.txt","w")
'''
'''
file=open("C:/users/sinan/desktop/newfile.txt",'w') #içindekileri siler
file=open("C:/users/sinan/desktop/newfile.txt",'a') # içindekilere ekler

file.write('\nyeni program \n ha bu yemdur')
for i in range(10):
    file.writelines('\n-'+str(i+1)+'-')
    for i in range(10):
        file.write(str(i))
if not file.close(): 
    file.close()
'''
'''
file=open("C:/users/sinan/desktop/newfile.txt",'w',encoding='UTF-8') #utf-8 tr karekter desteği var
file.write(file.encoding+'\tĞğÇçŞşıİ\n')#tr karakter btw
print(file.name)
file.write(file.name)#tr karakter btw
fileway=str(file.name).split('/')
for i in fileway:
    file.write('\n'+i+'/')
'''
##### read(a) //a=okunacak char sayısı okuduktan sonra imleç a+1. elemanda  ########
##### readline() satır okur, readlines() list yapar
'''
file=open("C:/users/sinan/desktop/newfile.txt",'r')
print(file.read(10))
print(file.read(4))
print(file.read(8))
print(file.read())
'''
'''
file=open("C:/users/sinan/desktop/newfile.txt",'r',encoding='utf-8')
aaa=file.readlines()
print(aaa[3],end='')

file.close()
'''
'''
with open("C:/users/sinan/desktop/newfile.txt","r+", encoding="utf-8") as file:
    list = file.readlines()
    list.insert(1,"Yılmaz Aygün\n")
    file.seek(0)
    file.writelines(list)

with open("C:/users/sinan/desktop/newfile.txt","r", encoding="utf-8") as file:
    print(file.read())
'''