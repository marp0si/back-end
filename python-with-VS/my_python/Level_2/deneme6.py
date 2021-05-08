import requests 
import json,os

sourceweb='https://api.exchangeratesapi.io/latest?base='
source=requests.get(sourceweb)
source=source.text
source=json.loads(source)
print('1 '+str({source['base']})+','+str({source['rates']['AUD']}))


