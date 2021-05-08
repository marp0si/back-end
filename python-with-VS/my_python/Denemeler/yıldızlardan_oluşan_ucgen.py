def a ():
	print('lütfen 48den küçük olsun kappa')
	try:
		n=int(input('sayı girin: '))
		yıldızsay=1
		boşluksay=n-1
		if n%2==1:
				n=n+1
		for i in range(int(n)):
			print((int(boşluksay/2))*" ",end='')
			print((int(yıldızsay))*"*",end='')
			print((int(boşluksay/2))*'  ')
			yıldızsay=yıldızsay+2
			boşluksay=boşluksay-2
			if boşluksay==1 or boşluksay==0:
				print(i)
				break
	except ValueError:
		print('sayı gir keriz')
		pass
while 1:
	a()