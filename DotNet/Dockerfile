FROM microsoft/dotnet:2.0-sdk as build
WORKDIR /app
WORKDIR /app/win
WORKDIR /testResult
WORKDIR /src
COPY *.sln ./
COPY FunctionTestHelper/FunctionTestHelper.csproj FunctionTestHelper/
COPY DotNet/DotNet.csproj DotNet/
COPY DotNet.Test/DotNet.Test.csproj DotNet.Test
RUN dotnet restore -s https://www.myget.org/F/azure-appservice/api/v3/index.json -s https://api.nuget.org/v3/index.json
COPY . . 
WORKDIR /src/FunctionTestHelper
RUN dotnet build -c Release -o /app -c FunctionTestHelper.csproj 
WORKDIR /src/DotNet
RUN dotnet build -c Release -o /app -c DotNet.csproj
WORKDIR /src/DotNet.Test
RUN dotnet build -c Release -o /app -c DotNet.Test.csproj
# RUN dotnet test --logger "trx;LogFileName=aaa.trx"

WORKDIR /src/DotNet
RUN dotnet build -c Release -o /app/win -c DotNet.csproj --runtime win10-x64

WORKDIR /src
ENTRYPOINT ["/bin/bash", "test.sh"]


