import re
text3='Kuzudasda Kuzudasda Kuzuasdasd Kuzudasdas dsadasme dasdasdame dsadasdme'
text3=text3.split(' ')
for i in text3:
    a=re.findall('^Kuzu....',i)
    if not a==[]:print(a)     
    a=re.findall('....me$',i)
    if not a==[]:print(a)
    
