---
layout: default
title: Dapper Plus - Bulk Delete
permalink: bulk-delete
---

{% include template-h1.html %}
DELETE entities using Bulk Operation.

- [Delete single](#example---delete-single)
- [Delete many](#example---delete-many)

## Example - Delete Single
DELETE a single entity with Bulk Operation.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    connection.BulkDelete(invoice);
}
{% endhighlight %}

## Example - Delete Many
DELETE many entities with Bulk Operation.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    connection.BulkDelete(invoices);
}
{% endhighlight %}
