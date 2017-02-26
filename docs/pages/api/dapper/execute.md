---
layout: default
title: Dapper - Execute 
permalink: execute
---

{% include template-h1.html %}

## Description
Execute a command one or multiple times and return the number of affected rows. This method is usually used to execute:
- [Stored Procedure](#example---execute-stored-procedure)
- [INSERT statement](#example---execute-insert)
- [UPDATE statement](#example---execute-update)
- [DELETE statement](#example---execute-delete)

## Example - Execute Stored Procedure

### Single
Execute the Stored Procedure a single time.

{% highlight csharp %}
example
{% endhighlight %}

### Many
Execute the Stored Procedure multiple times. Once for every object in the array list.

{% highlight csharp %}
example
{% endhighlight %}

## Example - Execute INSERT

### Single
Execute the INSERT Statement a single time.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    var affectedRows = connection.Execute(My.SqlText.InvoiceInsert, new {Code = "Single_Insert_1"});
}
{% endhighlight %}

### Many
Execute the INSERT Statement multiple times. Once for every object in the array list.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    var affectedRows = connection.Execute(My.SqlText.InvoiceInsert,
        new[]
        {
            new {Code = "Many_Insert_1"},
            new {Code = "Many_Insert_2"},
            new {Code = "Many_Insert_3"}
        }
    );
}
{% endhighlight %}

## Example - Execute UPDATE

### Single
Execute the UPDATE Statement a single time.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    var affectedRows = connection.Execute(My.SqlText.InvoiceUpdate, new {InvoiceID = 1, Code = "Single_Update_1"});
}
{% endhighlight %}

### Many
Execute the UPDATE Statement multiple times. Once for every object in the array list.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    var affectedRows = connection.Execute(My.SqlText.InvoiceUpdate,
        new[]
        {
            new {InvoiceID = 1, Code = "Many_Update_1"},
            new {InvoiceID = 2, Code = "Many_Update_2"},
            new {InvoiceID = 3, Code = "Many_Update_3"}
        });
}
{% endhighlight %}

## Example - Execute DELETE

### Single
Execute the DELETE Statement a single time.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    var affectedRows = connection.Execute(My.SqlText.InvoiceDelete, new {InvoiceID = 1});
}
{% endhighlight %}

### Many
Execute the DELETE Statement multiple times. Once for every object in the array list.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    var affectedRows = connection.Execute(My.SqlText.InvoiceDelete,
        new[]
        {
            new {InvoiceID = 1},
            new {InvoiceID = 2},
            new {InvoiceID = 3}
        });
}
{% endhighlight %}
