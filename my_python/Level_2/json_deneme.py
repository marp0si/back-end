import json,os
class user: 
    isuseractive=False
    def __init__(self,user,password):
        self.users=user
        self.passwords=password
    def login(self,kullanıcıİd,kullanıcıPass):
        if self.users==kullanıcıİd and kullanıcıPass==self.passwords:
            self.isuseractive=True
            print('login accent')
        else :
            print('users or/and password is not matched ')    
    def logout(self):
        self.isuseractive=False
        print('logout accent')
        
with open('users.json','r+') as f:
    files=json.load(f)
    kullanıcı1=files[0]
    kullanıcı1=json.loads(kullanıcı1)
    kullanıcıİd='all users is ofline'    
    user1=user(kullanıcı1['username'],kullanıcı1['password'])


while True:  
    print('Menü'.center(30,'*'))
    secim=input('1-login\n2-logout\n3-online users\n0-exit\n')  
    if secim=='1':#login
        if not user1.isuseractive:
            kullanıcıİd=input('user: ')
            kullanıcıPass=input('Password: ')
            user1.login(str(kullanıcıİd),str(kullanıcıPass))
        else:
            print(f'{kullanıcıİd} is actived')

    elif secim=='2':#logout
        user1.logout()
        pass
    elif secim=='3':#logout
        print(kullanıcı1['username'])
    elif secim=='0':
        break
    else:
        print('1 veya 2 seçiminizi yapın')

        

