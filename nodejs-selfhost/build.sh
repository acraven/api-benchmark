#!/bin/bash

docker build -t api-benchmark-nodejs:latest .
docker run -it -p 8100:8100 api-benchmark-nodejs:latest
