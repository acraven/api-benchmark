ip=$(docker-machine ip)

docker-compose up --build -d

ab.exe -n 20 http://$ip:8110/ping > /dev/null
ab.exe -n 40000 -c 20 http://$ip:8110/ > results/nodejs.txt 

ab.exe -n 20 http://$ip:8105/ping > /dev/null
ab.exe -n 40000 -c 20 http://$ip:8105/ > results/aspnetcore-mvc.txt 

ab.exe -n 20 http://$ip:8120/ping > /dev/null
ab.exe -n 40000 -c 20 http://$ip:8120/ > results/aspnetcore-http.txt 

ab.exe -n 20 http://$ip:8130/ping > /dev/null
ab.exe -n 40000 -c 20 http://$ip:8130/ > results/mono-owin.txt 

docker-compose down