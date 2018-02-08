#! /bin/bash

cd /src/DotNet.Test
dotnet test --logger "trx;LogFileName=/testResult/testResult.trx"
cp -R /app/win /testResult/win
