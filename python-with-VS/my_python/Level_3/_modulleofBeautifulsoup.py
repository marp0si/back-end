# * important pip install beautifulsoup4
soup_doc="""
<!DOCTYPE html>
<html lang="en">
<head> 
<script src='index.js'></script>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>h1(en kalın-büyük başlık)</h1>
    <div class="Bir"><ul>
         <li>
            1x1
         </li>
         <li>
            1x2

         </li>
         <li>
            1x3
            </li>
        </ul>
    </div>
    <div class="Iki">
    <ul>
    <li>
            2x1
    </li>
    <li>
            2x2
    </li>
    <li>
            3x3

    </li>
</ul>
</div>
            

<h2>başlık</h2>
</body>
</html>

"""
from bs4 import BeautifulSoup
soup = BeautifulSoup(soup_doc,'html.parser')
result=soup.prettify()#* html'i derler 
result=soup.head
result=soup.head.name
result=soup.head.string
result=soup.body.div
result=result.prettify()


result=soup.find_all('div')
result=soup.find_all('div')[0].ul.find_all('li')
result=soup.div.findChildren()
result=soup.find_all('div')[1].findChildren()

#result=result.prettify()

print(result)
