FROM microsoft/dotnet:core

WORKDIR /app

COPY publish/ /app/

EXPOSE 8120
ENTRYPOINT dotnet aspnetcore-owin-selfhost.dll
