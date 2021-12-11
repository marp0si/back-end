
import hashlib 

def devammi():
    Dev=input("devam mı:(y/n)")
    if Dev=="y" or Dev=="Y":
        md5()
    elif Dev=="n" or Dev=="N":
        print("cikiliyor.....")
    else :
        print("lütfen geçerli karakter girin: ")
        devammi()
    print("bay bayyyy")

def md5():
    text=input("Text:")
    text1 = hashlib.md5(text.encode())  
    print(text1.hexdigest()) 
    devammi()

md5()
