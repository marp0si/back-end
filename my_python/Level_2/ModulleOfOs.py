import os

'''
result=os.name
result=os.getcwd()#bulunduğu yol
#os.chdir('C:\\')#bulunan klasörü değitirir
#os.chdir('..\\')#..\.. 2 üst klasörü bulunduğu yer yapar
#os.mkdir('yeniklasör') dosya açar
#os.makedirs('newdir/yeniklasör')#klasör içinde klasör oluşturabilir
os.listdir()# klasör içinde bulunan dosyaları list içine alır
os.system('command_line')
os.startfile('deneme.txt')
os.replace('deneme', 'test')
os.remove('')
os.rename('eski-ad',yeni-ad)#yine ad koyar
os.rmdir('klasör-adı')#tek klasör siler
os.removedirs('klasör-adı/yeniklasör') alt klasörleri siler
os.path.
        .abspath('module-of-os.py') tam konumunu verir##(file_way+'file.name')
        .dirname('C:/....../Level_2/module-of-os.py')# dizisini verir #file_way
        .exists("C:/python/advanced-modules")#var mı yok mu diye bakar
        .join('')#pad oluşturur ama konrol edildiğinde false alırız
        .split(files_way)#yol ve dosya olucak şekilde 2ye böler ve tuple'a atar
        .splitext('')dosya ve uzantısı olucak şekilde ikiye böler ve tuple'a atar

'''
result=os.name
result=os.getcwd()#bulunduğu yol
#os.chdir('C:\\')#bulunan klasörü değitirir
#os.mkdir('') dosya açar
#os.chdir('..')#'..'bulunduğu yerin bi üst klasörüne çıkar
#os.chdir('..\\..')
#os.chdir('..\\')#..\.. 2 üst klasörü bulunduğu yer yapar
result=os.getcwd()
#print(result)
#os.makedirs('')#klasör içinde klasör oluşturabilir
liste=[]
result=os.listdir()# klasör içinde bulunan dosyaları list içine alır


for i in result:
    liste.append(i)
#print(liste)


#os.chdir('..')
result=os.getcwd()
#print(result)

files_way=str(result)+'\\'+liste[1]
'''
import datetime
result=os.stat(liste[0])
print(result)
result=result.st_size#byte cinsinden boyutu
print(f'{result} byte')

result=datetime.datetime.fromtimestamp(result.st_ctime)#--> oluşturma T(created)
result=datetime.datetime.fromtimestamp(result.st_atime)#--> son erişme T(access)
result=datetime.datetime.fromtimestamp(result.st_mtime)#--> değiştirme T(modified)

'''

#print(datetime.datetime.fromtimestamp(result.st_ctime))
#print(datetime.datetime.fromtimestamp(result.st_atime))
#print(datetime.datetime.fromtimestamp(result.st_mtime))

'''
files=open(files_way,'r',encoding='UTF-8')
#print(files.read())
files.close()
'''
#print(result)
#os.system('cd')#içine yazılan cmd komutlarını uygulara
#os.startfile('dates_and_times.txt')
sys=os.path.abspath('module-of-os.py')
sys=os.path.dirname('C:/Users/Sinan/Desktop/python-learning/my_python/Level_2/module-of-os.py')
sys=os.path.dirname(os.path.abspath("module-of-os.py"))
sys=os.path.exists("C:/python/advanced-modules")# var mı yok mu diye bakar #false
sys=os.path.join('C:\\','sdadsa','dsad')
sys=os.path.split(files_way)
sys = os.path.splitext("_os.py")
print(sys)
os.system('cls')