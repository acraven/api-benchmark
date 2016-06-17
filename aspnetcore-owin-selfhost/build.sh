#!/bin/bash

rm -rf publish
mkdir publish

dotnet restore project.json
dotnet publish -c Release -f netcoreapp1.0 -o publish project.json
docker build -t api-benchmark-aspnetcore-owin:latest .
docker run -it -p 8120:8120 api-benchmark-aspnetcore-owin:latest
