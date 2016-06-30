FROM mono:4.4.0.182

WORKDIR /app

COPY bin/Release/ /app/

EXPOSE 8130
ENTRYPOINT mono Api.Benchmark.Owin.Mono.SelfHost.exe