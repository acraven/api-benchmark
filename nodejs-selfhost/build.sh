#!/bin/bash

docker build -t api-benchmark-nodejs:latest .
docker run -it -p 8110:8110 api-benchmark-nodejs:latest
