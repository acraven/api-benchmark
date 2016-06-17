FROM microsoft/dotnet:core

WORKDIR /app

COPY publish/ /app/

EXPOSE 8100
ENTRYPOINT dotnet aspnetcore-selfhost.dll
