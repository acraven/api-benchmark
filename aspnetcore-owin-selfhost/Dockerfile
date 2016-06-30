FROM microsoft/dotnet:1.0.0-core

WORKDIR /app

COPY publish/ /app/

EXPOSE 8120
ENTRYPOINT dotnet aspnetcore-owin-selfhost.dll
