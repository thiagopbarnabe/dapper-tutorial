---
layout: default
title: Dapper - QueryFirstOrDefault
permalink: queryfirstordefault
---

{% include template-h1.html %}

## Description
Execute a SQL and return the first result.

The result can be from different type:

- [Anonymous](#query-anonymous)
- [Strongly Typed](#query-strongly-typed)
- [Multi-Mapping](#query-multi-mapping)
- [Multi-Result](#query-multi-result)
- [Multi-Type](#query-multi-type)

> FirstOrDefault vs SingleOrDefault: FirstOrDefault return the first element of a sequence or default value if the sequence contain no element. SingleOrDefault throw an exception if more than 1 element is found in the sequence.


### Query Overloads

{% highlight csharp %}
object QueryFirstOrDefault(this IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
object QueryFirstOrDefault(this IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
T QueryFirstOrDefault<T>(this IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
T QueryFirstOrDefault<T>(this IDbConnection cnn, CommandDefinition command)
{% endhighlight %}

## Query Anonymous
{% include template-example.html %} 
{% highlight csharp %}
using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString, transaction))
{
    // SET BatchSize value.
    bulkCopy.BatchSize = 4000;

    bulkCopy.DestinationTableName = "TheDestinationTable";
    bulkCopy.WriteToServer(dt);
}
{% endhighlight %}

## Query Strongly Typed
{% include template-example.html %} 
{% highlight csharp %}
using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString, transaction))
{
    // SET BatchSize value.
    bulkCopy.BatchSize = 4000;

    bulkCopy.DestinationTableName = "TheDestinationTable";
    bulkCopy.WriteToServer(dt);
}
{% endhighlight %}

## Query Multi-Mapping
{% include template-example.html %} 
{% highlight csharp %}
using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString, transaction))
{
    // SET BatchSize value.
    bulkCopy.BatchSize = 4000;

    bulkCopy.DestinationTableName = "TheDestinationTable";
    bulkCopy.WriteToServer(dt);
}
{% endhighlight %}

## Query Multi-Result
{% include template-example.html %} 
{% highlight csharp %}
using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString, transaction))
{
    // SET BatchSize value.
    bulkCopy.BatchSize = 4000;

    bulkCopy.DestinationTableName = "TheDestinationTable";
    bulkCopy.WriteToServer(dt);
}
{% endhighlight %}

## Query Multi-Type
{% include template-example.html %} 
{% highlight csharp %}
using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString, transaction))
{
    // SET BatchSize value.
    bulkCopy.BatchSize = 4000;

    bulkCopy.DestinationTableName = "TheDestinationTable";
    bulkCopy.WriteToServer(dt);
}
{% endhighlight %}
