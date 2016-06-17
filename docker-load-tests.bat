mkdir docker-results

ab.exe -n 20 http://192.168.99.100:8100/
ab.exe -n 40000 -c 20 http://192.168.99.100:8100/ > docker-results\aspnetcore-selfhost.txt 

ab.exe -n 20 http://192.168.99.100:8110/
ab.exe -n 40000 -c 20 http://192.168.99.100:8110/ > docker-results\nodejs-selfhost.txt 
