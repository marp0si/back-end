import pagan
inpt =input("")
img=pagan.Avatar(inpt,paganSHA512)
img.show()
outpath='output/'
filename=inpt+".png"
img.save(outpath,filename)