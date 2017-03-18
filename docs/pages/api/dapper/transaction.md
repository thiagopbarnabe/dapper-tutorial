---
layout: default
title: Dapper - Transaction
permalink: transaction
---

{% include template-h1.html %}

## Description
Dapper support the transaction and TransactionScope

## Transaction

Begin a new transaction from the connection and pass it in the transaction optional parameter.

```csharp
using (var connection = My.ConnectionFactory())
{
	connection.Open();

	using (var transaction = connection.BeginTransaction())
	{
		var affectedRows = connection.Execute(My.SqlText.InvoiceInsert, new { Code = "Single_Insert_1" }, commandType: CommandType.StoredProcedure, transaction: transaction);

		transaction.Commit();
	}
}
```

## TransactionScope

Begin a new transaction scope before starting the connection

```csharp
// using System.Transactions;

using (var transaction = new TransactionScope())
{
	using (var connection = My.ConnectionFactory())
	{
		connection.Open();

		var affectedRows = connection.Execute(My.SqlText.InvoiceInsert, new { Code = "Single_Insert_1" }, commandType: CommandType.StoredProcedure);
	}
}
```
