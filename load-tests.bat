mkdir results

ab.exe -n 20 http://localhost:8080/
ab.exe -n 40000 -c 20 http://localhost:8080/ > results\nancy-selfhost.txt 

ab.exe -n 20 http://localhost:8090/
ab.exe -n 40000 -c 20 http://localhost:8090/ > results\owin-selfhost.txt 

ab.exe -n 20 http://192.168.99.100:8100/
ab.exe -n 40000 -c 20 http://192.168.99.100:8100/ > results\aspnetcore-selfhost.txt 

ab.exe -n 20 http://192.168.99.100:8110/
ab.exe -n 40000 -c 20 http://192.168.99.100:8110/ > results\nodejs-selfhost.txt 
