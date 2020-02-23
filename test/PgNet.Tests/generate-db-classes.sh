#!/usr/bin/env bash

set -exu

pg-net-generator() {
    local HERE=`pwd`;
    cd ../../src/PgNetGenerator/    
    dotnet run -- "$@" >&1
    cd $HERE;
}

CONNECTION_STRING="Server=dev-host.lan;Port=4202;Database=test;Uid=test;Pwd=test123;";

pg-net-generator -c $CONNECTION_STRING -n "PgNet.Tests" -o- > "./TestPocos.cs"
pg-net-generator -c $CONNECTION_STRING -n "PgNet.Tests" -t "../../test/PgNet.Tests/tests-template.txt" -o- > "./DbTests.cs"
