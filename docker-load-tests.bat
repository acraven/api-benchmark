mkdir docker-results

ab.exe -n 20 http://192.168.99.100:8105/
ab.exe -n 40000 -c 20 http://192.168.99.100:8105/ > docker-results\aspnetcore-selfhost.txt 

ab.exe -n 20 http://192.168.99.100:8110/
ab.exe -n 40000 -c 20 http://192.168.99.100:8110/ > docker-results\nodejs-selfhost.txt 

ab.exe -n 20 http://192.168.99.100:8120/
ab.exe -n 40000 -c 20 http://192.168.99.100:8120/ > docker-results\aspnetcore-owin-selfhost.txt 

ab.exe -n 20 http://192.168.99.100:8130/
ab.exe -n 40000 -c 20 http://192.168.99.100:8130/ > docker-results\owin-mono-selfhost.txt 

echo done
