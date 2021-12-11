def carp(sayı):
    numara=10
    return numara*sayı
numara=20
print(carp(10))

##local, enclosing, global, built-in
ad='sinan'#global
def fonsiyon():
    ad="sinan1"
    #enclosing
    def fonsiyon1():
        ad="sinan2"
        #local
    fonsiyon1()
fonsiyon()
def fonsiyon11():
    global ad
    ad="sino11"
    return ad
print(fonsiyon11())
print(ad)