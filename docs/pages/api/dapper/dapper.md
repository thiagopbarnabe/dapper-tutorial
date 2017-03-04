---
layout: default
title: Dapper 
permalink: dapper
---

{% include template-h1.html %}

## What's Dapper?
Dapper is a simple object mapper for .NET and also own the title of **King of Micro ORM**

Dapper extend the IDbConnection by providing useful helper to query your database.

## Installation
Dapper is installed through NuGet: <a href="https://www.nuget.org/packages/Dapper" target="_blank">https://www.nuget.org/packages/Dapper</a>

> PM> Install-Package Dapper

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
string sp = "EXEC Invoice_Insert";
string sqlInvoices = "SELECT * FROM Invoice;";
string sqlInvoice = "SELECT * FROM Invoice WHERE InvoiceID = @InvoiceID;";

using (var connection = My.ConnectionFactory())
{
	var affectedRows = connection.Execute(sp, new { Param1 = "Single_Insert_1" }, commandType: CommandType.StoredProcedure);
	var invoices = connection.Query<Invoice>(sqlInvoices).ToList();
	var invoice = connection.QueryFirstOrDefault(sqlInvoice, new {InvoiceID = 1});
}
{% endhighlight %}

## Parameter
Execute and queries method can use parameters from multiple different ways:

- [Anonymous](/parameter-anonymous)
- [Dynamic](/parameter-dynamic)
- [List](/parameter-list)
- [String](/parameter-string)

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
}
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
