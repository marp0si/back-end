a="abcdefg abcd"
print(a[len(a)-4])#a
website="http://www.abcabcabc.com"
name,surname='sinan','bilgili'
result=website[7:10]#www
result=website[::-1]##moc.cbacbacba.www//:ptth
#print(name,surname)##('sinan', 'bilgili')
#print(result+"\n"+website)


s="  hello  there"
s=s.upper()##  HELLO  THERE
s=s.lower()##  hello  there

s=s.title()##  Hello  There
s=s.capitalize()##  hello  there

isFound=s.startswith('h')##true
isFound=s.endswith("e")##true
index=s.find("there")## 6
s=s.replace("e","E")#Hello there
###s=s.split()##['hello', 'there']##
print(s)
sinan="Bu cumle 28 karakter var mi?"
sayi=len(sinan)

if sayi==28 or sayi>=len(sinan):## Or-And
    print("Evet 28 karakterdir. ")

# * important
# ! dont use 
# ? should thiss method be exposed in the public
# TODO: refactor this method so that it conform to the api
# // this line of code out






