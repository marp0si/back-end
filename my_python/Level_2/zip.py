##zip

yemek_listesi=["muz","ananas","elma"]
kalori_list=[100,200,300]
gün_list=["pazartesi","salı","çarşamba"]
ziplenmis_liste=list(zip(yemek_listesi,kalori_list,gün_list))

for eleman in ziplenmis_liste:
    print(eleman)
