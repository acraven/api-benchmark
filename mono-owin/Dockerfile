FROM mono:4.6.2.7

RUN apt-get update \
  && apt-get install -y wget

WORKDIR /app

RUN wget https://dist.nuget.org/win-x86-commandline/latest/nuget.exe

COPY . /app
RUN mono nuget.exe restore Api.Benchmark.Mono.Owin.sln
RUN xbuild /property:Configuration=Release Api.Benchmark.Mono.Owin.csproj

EXPOSE 8130
CMD [ "mono", "bin/Release/Api.Benchmark.Mono.Owin.exe" ]