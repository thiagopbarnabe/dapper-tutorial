---
layout: default
title: Dapper - Async
permalink: async
---

{% include template-h1.html %}

## Description
Dapper also extend the IDbConnection interface with Async (asynchronous) methods:
- ExecuteAsync
- QueryAsync
- QueryFirstAsync
- QueryFirstOrDefaultAsync
- QuerySingleAsync
- QuerySingleOrDefaultAsync
- QueryMultipleAsync

> We only added non-asynchronous version in this tutorial to make it easier to read.

{% highlight csharp %}
string sqlInvoices = "SELECT * FROM Invoice;";
string sqlInvoice = "SELECT * FROM Invoice WHERE InvoiceID = @InvoiceID;";
string sp = "EXEC Invoice_Insert";

using (var connection = My.ConnectionFactory())
{
	var invoices = connection.QueryAsync<Invoice>(sqlInvoices).ToList();
	var invoice = connection.QueryFirstOrDefaultAsync(sqlInvoice, new {InvoiceID = 1});
	var affectedRows = connection.ExecuteAsync(sp, new { Param1 = "Single_Insert_1" }, commandType: CommandType.StoredProcedure);
}
{% endhighlight %}
