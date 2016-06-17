#!/bin/bash

rm -rf publish
mkdir publish

dotnet restore project.json
dotnet publish -c Release -f netcoreapp1.0 -o publish project.json
docker build -t aspnetcore-owin-selfhost:latest .
docker run -it -p 8120:8120 aspnetcore-owin-selfhost:latest
