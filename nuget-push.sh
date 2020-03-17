#!/usr/bin/env bash

PACKAGE_DIR="./packages";

if [ -d "$PACKAGE_DIR" ]; then
    rm $PACKAGE_DIR -rf
fi

dotnet pack -c release -o $PACKAGE_DIR --include-symbols --include-source -p:SymbolPackageFormat=snupkg

find ./ -name '*.nupkg' -print0 | while read -d $'\0' file; do
    dotnet nuget push $file -k $NUGET_KEY -s https://api.nuget.org/v3/index.json
done

if [ -d "$PACKAGE_DIR" ]; then
    rm $PACKAGE_DIR -rf
fi
