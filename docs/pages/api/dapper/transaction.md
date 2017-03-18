---
layout: default
title: Dapper - Transaction
permalink: transaction
---

{% include template-h1.html %}

## Description
Dapper support the transaction and TransactionScope

## Transaction

```csharp
using (var connection = My.ConnectionFactory())
{
	connection.Open();

	using (var transaction = connection.BeginTransaction())
	{
		var affectedRows = connection.Execute(My.SqlText.InvoiceInsert, new { Code = "Single_Insert_1" }, commandType: CommandType.StoredProcedure);

		transaction.Commit();
	}
}
```

## TransactionScope

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
