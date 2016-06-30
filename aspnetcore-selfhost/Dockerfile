FROM microsoft/dotnet:1.0.0-core

WORKDIR /app

COPY publish/ /app/

EXPOSE 8105
ENTRYPOINT dotnet aspnetcore-selfhost.dll
