#!/bin/bash

export PATH="/c/Program Files (x86)/Mono/bin":$PATH

rm -rf bin/release

../.nuget/nuget restore Api.Benchmark.Owin.Mono.SelfHost.sln
xbuild /property:Configuration=Release Api.Benchmark.Owin.Mono.SelfHost.csproj

docker build -t api-benchmark-mono-owin:latest .
docker run -it -p 8130:8130 api-benchmark-mono-owin:latest
