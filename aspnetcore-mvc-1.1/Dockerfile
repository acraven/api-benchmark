FROM microsoft/dotnet:1.1.0-sdk-projectjson

WORKDIR /app

COPY . /app
RUN dotnet restore

EXPOSE 8111
CMD [ "dotnet", "run", "-c", "Release" ]
