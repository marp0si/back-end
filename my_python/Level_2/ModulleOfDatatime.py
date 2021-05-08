from datetime import datetime
from datetime import timedelta
import time 
#import datetime
def aa():
    simdi = datetime.now()
    simdi = datetime.today()

    result = datetime.now()
    result = simdi.year
    result = simdi.month
    result = simdi.day
    result = simdi.hour
    result = simdi.minute
    result = simdi.second

    t = '15 April 2019 hour 10:12:30'
    result = datetime.strptime(t, '%d %B %Y hour %H:%M:%S')
    result = result.year

    simdikitarihzaman=datetime.now()
    simdikitarih=str(simdikitarihzaman).split(" ")
    simdikitarih1=simdikitarih[0].split("-")
    simdikizaman=simdikitarih[1].split(":")
    simdikisaat=simdikizaman[0]
    simdikidakika=simdikizaman[1]
    simdikisaniye=simdikizaman[2]
    simdikiyıl=simdikitarih1[0]
    simdikiAy=simdikitarih1[1]
    simdikiGün=simdikitarih1[2]

    gün=simdikitarihzaman.strftime("%A")#Weekday,full ver.                  friday
    gün=simdikitarihzaman.strftime("%w")#weekday,number 0-6,0 is sunday.    6
    gün=simdikitarihzaman.strftime("%d")#Day of month 0-31                  20
    gün=simdikitarihzaman.strftime("%B")#month fullname                     December
    gün=simdikitarihzaman.strftime("%m")#month as number                    12
    gün=simdikitarihzaman.strftime("%y")#year full ver.                     2020
    gün=simdikitarihzaman.strftime("%h")#hour 0-24                          23
    gün=simdikitarihzaman.strftime("%m")#minute 00-59                       10  
    gün=simdikitarihzaman.strftime("%A")#second 00-59                       53
    gün=simdikitarihzaman.strftime("%j")#day number of year                 340
    print(simdikitarihzaman)
while 1:
    #time.sleep()
    aa()
    
