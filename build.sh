#!/bin/bash

#install zip on debian OS, since microsoft/dotnet container doesn't have zip by default
if [ -f /etc/debian_version ]
then
  apt -qq update
  apt -qq -y install zip
fi

dotnet tool install -g Amazon.Lambda.Tools
dotnet restore
if [ -f /etc/debian_version ]
then
dotnet lambda package --configuration release --framework netcoreapp3.1 --output-package bin/release/netcoreapp3.1/hello.zip  --msbuild-parameters "/p:PublishReadyToRun=true --self-contained false"
else 
dotnet lambda package --configuration release --framework netcoreapp3.1 --output-package bin/release/netcoreapp3.1/hello.zip  
fi
