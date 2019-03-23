Teste Commit semiautomatico

#!/bin/sh
cd /f/Estacio/AprendendoCSharp/
git pull origin master
git add .
git commit -am "Commit semi-automático"
git push
echo Press Enter...
read