---
layout: default
title: Dapper 
permalink: dapper
---

{% include template-h1.html %}

## What's Dapper?
Dapper is a simple object mapper for .NET

A lot of people call this library the **King of Micro ORM**.

## Installation
Dapper is installed through NuGet: <a href="https://www.nuget.org/packages/Dapper" target="_blank">https://www.nuget.org/packages/Dapper</a>

## Requirement
Dapper work with any database provider since there is no DB specific implementation.

## Methods
Dapper will extend your IDbConnection interface with multiple methods:

- [Execute](/execute)
- [Query](/query)
- [QueryFirst](/queryfirst)
- [QueryFirstOrDefault](/queryfirstordefault)
- [QuerySingle](/querysingle)
- [QuerySingleOrDefault](/querysingleordefault)
- [QueryMultiple](/querymultiple)

{% highlight csharp %}
example
{% endhighlight %}

## Parameter
Execute and queries method can use parameters from multiple different ways:

- [Anonymous](/parameter-anonymous)
- [Dynamic](/parameter-dynamic)
- [List](/parameter-list)
- [String](/parameter-string)

{% highlight csharp %}
example
{% endhighlight %}

## Result
The result returned by queries method can be mapped to multiple types:

- [Anonymous](/result-anonymous)
- [Strongly Typed](/result-strongly-typed)
- [Multi-Mapping](/result-multi-mapping)
- [Multi-Result](/result-multi-result)
- [Multi-Type](/result-multi-type)

{% highlight csharp %}
example
{% endhighlight %}

## Utilities

- [Stored Procedure](stored-procedure)

{% highlight csharp %}
example
{% endhighlight %}
