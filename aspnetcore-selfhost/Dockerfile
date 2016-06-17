FROM microsoft/dotnet

COPY . /app
WORKDIR /app

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

EXPOSE 8100
ENTRYPOINT ["dotnet", "run", "--server.urls http://0.0.0.0:8100"]