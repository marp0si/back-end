import re #regular expression
result=dir(re)
'''
re.findall('text',str)#arar
            '^text',str #(str text ile başlıyo mu)
            '$text',str #(str text ile bitiyor mu)
re.split('text',str)#böler
re.sub(' ','-',str)#değiştirir
re.match('text',str) re.search('text',str)
  str.start()
  str.span()
  str.end()
  str.group()
'''
text='Aman Aman nereye geldik daha demin evdeydik 1234'
text2='aman amen amin amun amon'
text3='Kuzu Kuza me, Bin tepeme , Haydi gidelim , Ayşe teyzeme1'
#result=re.findall('Aman',text)#['Aman', 'Aman']
#result=re.sub(' ','-',text)#Aman-Aman-nereye-geldik-daha-demin-evdeydik
#result=re.match('Aman',text)
result=re.search('Aman',text)#<re.Match object; span=(0, 4), match='Aman'>
#result=result.span()#(0, 4)
#result=result.group()#Aman
#result=result.start()#0
#result=result.string #Aman Aman nereye geldik daha demin evdeydik
"""

    [] - Köşeli parantezler arasına yazılan bütün karakterler
         aranır.

         [abc] => a      : 1 match
                  ac     : 2 match 
                  Python : No matches

         [a-e]  => [abcde]
         [1-5]  => [12345]
         [0-39] => [01239]   

         [^abc] => abc dışındaki karakterler.
         [^0-9] => rakam olmayan karakterler.

"""
text='aman aman nereye geldik daha demin evdeydik 1234sat'
result = re.findall("[abc]",text)#a-a-a-a-
result = re.findall("[sat]",text)#a-a-a-a-s-a-t-
result = re.findall("[a-e]", text)#a-a-e-e-e-e-d-d-a-a-d-e-e-d-e-d-a-
result = re.findall("[a-z]", text)
#a-m-a-n-a-m-a-n-n-e-r-e-y-e-g-e-l-d-i-k-d-a-h-a-d-e-m-i-n-e-v-d-e-y-d-i-k-s-a-t-
#(a-z)arası karakterleri yazdırır
result = re.findall("[0-5]", text)#1,2,3,4,
result = re.findall("[^abc]", text)
#m,n, ,m,n, ,n,e,r,e,y,e, ,g,e,l,d,i,k, ,d,h, ,d,e,m,i,n, ,e,v,d,e,y,d,i,k, ,1,2,3,4,s,t,
#(a-b-c olaman karakterleri)
result = re.findall("[^0-9]", text)
#a,m,a,n, ,a,m,a,n, ,n,e,r,e,y,e, ,g,e,l,d,i,k, ,d,a,h,a, ,d,e,m,i,n, ,e,v,d,e,y,d,i,k, ,s,a,t,
#(sayı olmayan karakterleri)
result = re.findall("[Aaeiıöouü]",text)
#A-a-A-a-e-e-e-e-i-a-a-e-i-e-e-i-(sesli harfler)

"""
    . - Her hangi bir tek karakteri belirtir.

        .. => a    : No match
              ab   : 1 match
              abc  : 1 match
              abcd : 2 matches

    
"""
karaktersayısı=('.'*int(len(text)/2))#['Aman Aman nereye geldik ', 'daha demin evdeydik 1234']
#karaktersayısı=('.'*5)
result1=re.findall(karaktersayısı,text)
result2=re.findall('.m.n',text2)
def gör(dizi1):
    for i in (dizi1) :
        print(i,end=',')
        

#Aman Aman nereye geldik ,daha demin evdeydik 1234,
#aman,amen,amin,amun,amon
result1=re.findall('^K...',text3)
result2=re.findall('....1$',text3)
#gör(result1),gör(result2)
##### Kuzu-zeme1-

"""
     * - Bir karakterin sıfır ya da daha fazla sayıda olmasını 
         kontrol eder. 

         ma*n => mn     : 1 match
                 man    : 1 match
                 maaan  : 1 match
                 main   : No match (a' nın arkasına n gelmiyor.) 

"""
result1=re.findall('ma*n','main')
"""
    {} - Karakter sayısını kontrol eder.

        al{2}   => a karakterinin arkasına l karakteri 2 kez tekrarlamalı.
        al{2,3} => a karakterinin arkasına l karakteri en az 2 en fazla 3 kez tekrarlamalı.
        [0-9]{2,4} => en az 2 en çok 4 basamaklı sayılar.
"""
text='Aman Aman nereye geldik daha demin evdeydik 12a345a678a90'
result1 = re.findall("A...{1}", text)
result2 = re.findall("[0-9]{2,3}", text)
#gör(result1)#Aman-Aman-
#gör(result2)#12-345-678-90-12-345-678-90-
"""
    | - alternatif seçeneklerden birinin gerçekleşmesi gerekir.

        a|b => a ya da b

            cde =>    no match
            ade =>    1 match
            acdbea => 3 match 
"""

"""
    () - gruplamak için kullanılır.

         (a|b|c)xz => a,b,c karakterlerinin arkasına xz gelmelidir.
"""
gör(result)

