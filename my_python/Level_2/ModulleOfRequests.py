import requests #html SourceCode
import json,os
'''
source=requests.get('address')
result=source.text
result=json.loads(result)
for i in result:
    print(i['userId'])
'''

sourceweb='https://jsonplaceholder.typicode.com/todos'
#sourceweb='https://api.themoviedb.org/3
source=requests.get(sourceweb)
#<Response [200]>
result=source.text
print(type(result))#<class 'str'>
result=json.loads(result)
print(result[0])
for i in result:
    if not i['completed']==False and i['id']%3==0:
        print(i['id'])
'''
for i in result:
    print(i['id'])
'''


