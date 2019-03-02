#!/usr/bin/env bash

connectionString="Server=dev-host.lan;Port=4202;Database=test;Uid=test;Pwd=test123;";
namespace="PgNet.Tests";
pocoClassName="TestDbPocos";
metadataClassName="TestDbMetadata";

schema2code \
-c $connectionString \
-t "./db-classes-template.cshtml" \
-o "./TestPocos.cs" \
-n $namespace \
-p $pocoClassName \
-m $metadataClassName

schema2code \
-c $connectionString \
-t "./tests-template.cshtml" \
-o "./DbTests.cs" \
-n $namespace \
-p $pocoClassName \
-m $metadataClassName
