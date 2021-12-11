#pip install pygame
from pygame import mixer
mixer.init()
mixer.music.load("beep-beep-minus8-hd.mp3")
mixer.music.set_volume(0.7)
mixer.music.play()

while 1:
    print("p=durdur,r=devam ettir,e=sonlandır")
    print()
    query=input(" ")
    if query=="p":
        mixer.music.pause()
    elif query=="r":
        mixer.music.unpause()
    elif query=="e":
        mixer.music.stop()
        break