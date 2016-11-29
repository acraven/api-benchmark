rm -f -r results
mkdir results

ip=$(docker-machine ip)
if [ "$?" -ne "0" ]; then
  ip="localhost"
fi

echo "Using $ip"

docker-compose up --build -d

ab -n 20 http://$ip:8100/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8100/ > results/nodejs.txt 

ab -n 20 http://$ip:8110/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8110/ > results/aspnetcore-mvc.txt 

ab -n 20 http://$ip:8111/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8111/ > results/aspnetcore-mvc-1.1.txt 

ab -n 20 http://$ip:8120/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8120/ > results/aspnetcore-http.txt 

ab -n 20 http://$ip:8121/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8121/ > results/aspnetcore-http-1.1.txt 

ab -n 20 http://$ip:8130/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8130/ > results/mono-owin.txt 

ab -n 20 http://$ip:8140/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8140/ > results/mono-nancy.txt 

docker-compose down
