import json
# str-dict ilişkisi
result='{"a":"1","b":"2","c":"3","d":["a","b","c","d"],"e":"5"}'
'''
json.loads(str)
json.dumps(dic)#dic'i json kullanarak str'ye dönüştürür

with open('dosyaAdı','w') as f:
    json.dump(dic,f)
    json.load(str)



'''
#str='["ddsa ","dsadas","sdadsa"]'

result1='{"name":"ali","a":"1"}'
result_json=json.loads(result)
#print(result_json)



#####################################################################################
with open('C:/Users/Sinan/Desktop/python-learning/my_python/Level_2/deneme.json') as r:
    data=json.load(r) 
    print(data['a'])  

with open('C:/Users/Sinan/Desktop/python-learning/my_python/Level_2/users.json') as r:
    data=json.load(r) 
    #print(data)

#print(data)
resultstr=json.dumps(data)
#print(resultstr)
#['{"username": "123", "password": "123", "email": "123"}']
#["{\"username\": \"123\", \"password\": \"123\", \"email\": \"123\"}"]

with open('deneme1.json','a')as f:
    json.dump(result_json,f)
    result = json.dumps(result_json, indent= 4, sort_keys= True)
#print(result)


#a 1
#b 2
#c 3
#d a b c d
#e 5
#{
    #"a": "1",
    #"b": "2",
    #"c": "3",
    #"d": [
        #"a",                   #result
        #"b",
        #"c",
        #"d"
    #],
    #"e": "5"
#}



'''
def gör(dict1):
    if type(dict1)==dict:
        for i,a in dict1.items():
            if type(a)==list:
                print(i,end=' ')
                gör(a)
            else:print(i,a)

    elif type(dict1)==list:
        for a in dict1:
            print(a,end=' ')
        print('')
gör(result_json)
'''
'''
with open('users.json','r+')as f:
    files=json.load(f)
    for i in files:
        print(i)
    
#print(result)
'''

