#!/usr/bin/env bash

connection_string="Server=dev-host.lan;Port=4202;Database=test;Uid=test;Pwd=test123;";

schema2code -c $connection_string -o- > "./TestPocos.cs"
schema2code -c $connection_string -t "./tests-template.txt" -o- > "./DbTests.cs"
