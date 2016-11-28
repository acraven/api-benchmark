rm -f -r results
mkdir results

ip=$(docker-machine ip)
if [ "$?" -ne "0" ]; then
  ip="localhost"
fi

echo "Using $ip"

docker-compose up --build -d

ab -n 20 http://$ip:8110/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8110/ping > results/nodejs.txt 

ab -n 20 http://$ip:8105/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8105/ping > results/aspnetcore-mvc.txt 

ab -n 20 http://$ip:8120/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8120/ping > results/aspnetcore-http.txt 

ab -n 20 http://$ip:8130/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8130/ping > results/mono-owin.txt 

ab -n 20 http://$ip:8140/ping > /dev/null
ab -n 40000 -c 20 http://$ip:8140/ping > results/mono-nancy.txt 

docker-compose down