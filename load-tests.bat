mkdir results

ab.exe -n 20 http://localhost:8080/
ab.exe -n 40000 -c 20 http://localhost:8080/ > results\nancy.txt 

