---
layout: default
title: Dapper - Stored Procedure 
permalink: stored-procedure
---

{% include template-h1.html %}

## Description
Using Stored Procedure in Dapper is very easy, you simply need to specify the command type

```csharp
string sql = "EXEC Invoice_Insert";

using (var connection = My.ConnectionFactory())
{
    connection.Open();

    var affectedRows = connection.Execute(sql, new { Code = "Single_Insert_1" }, commandType: CommandType.StoredProcedure);

    My.Result.Show(affectedRows);
}
```
