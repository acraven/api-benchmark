#!/bin/bash

rm -rf build
mkdir build

dotnet restore Api.Benchmark.AspNetCore.SelfHost/project.json
dotnet build -c Release -f netcoreapp1.0 -o build Api.Benchmark.AspNetCore.SelfHost/project.json
docker build -t api-benchmark-aspnetcore:latest .
