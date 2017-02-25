---
layout: default
title: Dapper 
permalink: dapper
---

{% include template-h1.html %}

## What's Dapper?
Dapper is a simple object mapper for .NET

A lot of people call this library "**King of Micro ORM**".

## Installation
Dapper is installed throught NuGet: https://www.nuget.org/packages/Dapper

## Methods
Dapper will extend your IDbConnection interface with multiple methods:

- [Execute](/execute)
- [Query](/query)
- [QueryFirst](/queryfirst)
- [QueryFirstOrDefault](/queryfirstordefault)
- [QuerySingle](/querysingle)
- [QuerySingleOrDefault](/querysingleordefault)
- [QueryMultiple](/querymultiple)

## Parameter
Execute and queries method can use parameter from different way:

- [Anonymous](/parameter-anonymous)
- [Dynamic](/parameter-dynamic)
- [List](/parameter-list)
- [String](/parameter-string)

## Result
The result returned by queries method can be mapped to multiple type:

- [Anonymous](/result-anonymous)
- [Strongly Typed](/result-strongly-typed)
- [Multi-Mapping](/result-multi-mapping)
- [Multi-Result](/result-multi-result)
- [Multi-Type](/result-multi-type)

## Utilities

- [Stored Procedure](stored-procedure)
