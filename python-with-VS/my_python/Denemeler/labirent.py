labirent1,labirent2,labirent3,labirent4=[],[],[],[]
for a in range(20):
    labirent2.append(0)
    labirent1.append(0)
    labirent3.append(0)
    labirent4.append(0)
labirent=labirent1,labirent2,labirent3,labirent4
labirent[1][0]="X"
labirent[2][1]="|"
labirent[1][3]="|"
labirent[1][13]="|"
labirent[1][9]="|"
labirent[1][15]="|"
labirent[3][2]="|"
labirent[2][4]="|"
labirent[2][7]="|"
labirent[2][9]="|"
labirent[2][15]="|"
labirent[3][6]="|"
labirent[3][11]="|"
for a in range(len(labirent)):
    for b in range(len(labirent[a])):
        if labirent[a][b]==0:
            labirent[a][b]="_"
def kareler():
    for a in range(len(labirent)):
        print("")
        for b in range(len(labirent[a])):
            print(labirent[a][b],end="")
    pass

kareler()
xx,yy="",""
def hareket(har,xx,yy):
    xx,yy="",""
    if labirent[0].count("X")!=0:
        yy=0
        xx=labirent[0].index("X")
    elif labirent[1].count("X")!=0:
        yy=1
        xx=labirent[1].index("X")
    elif labirent[2].count("X")!=0:
        yy=2
        xx=labirent[2].index("X")
    else:
        yy=3
        xx=labirent[3].index("X")    
    
    print(xx,yy)
    if har=="<" and labirent[yy][xx-1]=='_':
        labirent[yy][xx]="_"
        labirent[yy][xx-1]="X"    
    elif har=="^" and labirent[yy-1][xx]=='_':
        labirent[yy][xx]="_"
        labirent[yy-1][xx]="X"
    elif har=="v" and labirent[yy+1][xx]=='_':
        labirent[yy][xx]="_"
        labirent[yy+1][xx]="X"
    elif har==">" and labirent[yy][xx+1]=='_':
        labirent[yy][xx]="_"
        labirent[yy][xx+1]="X"
    else :hareket(input("<,>,^,v ==> yön seçin---"),xx,yy)
    kareler()
    print(xx,yy)
while xx!=3 and yy!=18:
    har=input("<,>,^,v ==> yön seçin")
    hareket(har,xx,yy)
print("tebrikler oyunu bitirdiniz!!!")        

    