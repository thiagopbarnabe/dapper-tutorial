---
layout: default
title: Dapper Plus - Bulk Merge
permalink: bulk-merge
---

{% include template-h1.html %}
MERGE entities using Bulk Operation.

- [Merge single](#example---merge-single)
- [Merge many](#example---merge-many)
- [Merge with relation (One to One)](#example---merge-with-relation-one-to-one)
- [Merge with relation (One to Many)](#example---merge-with-relation-one-to-many)

## Example - Merge Single
MERGE a single entity with Bulk Operation.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    connection.BulkMerge(invoice);
}
{% endhighlight %}

## Example - Merge Many
MERGE many entities with Bulk Operation.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    connection.BulkMerge(invoices);
}
{% endhighlight %}

## Example - Merge with relation (One to One)
MERGE entities with a one to one relation with Bulk Operation.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    connection.BulkMerge(invoices).ThenBulkMerge(x => x.InvoiceDetail);
}
{% endhighlight %}

## Example - Merge with relation (One to Many)
MERGE entities with a one to many relation with Bulk Operation.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    connection.BulkMerge(invoices).ThenBulkMerge(x => x.Items);
}
{% endhighlight %}
