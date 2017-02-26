---
layout: default
title: Dapper Plus - Bulk Insert
permalink: bulk-insert
---

{% include template-h1.html %}
INSERT entities using Bulk Operation.

- [Insert single](#example---insert-single)
- [Insert many](#example---insert-many)
- [Insert with relation (One to One)](#example---insert-with-relation-one-to-one)
- [Insert with relation (One to Many)](#example---insert-with-relation-one-to-many)

## Example - Insert Single
INSERT a single entity with Bulk Operation.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();
    
    connection.BulkInsert(invoice);
}
{% endhighlight %}

## Example - Insert Many
INSERT many entities with Bulk Operation.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    connection.BulkInsert(invoices);
}
{% endhighlight %}

## Example - Insert with relation (One to One)
INSERT entities with a one to one relation with Bulk Operation.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    connection.BulkInsert(invoices).ThenBulkInsert(x => x.InvoiceDetail);
}
{% endhighlight %}

## Example - Insert with relation (One to Many)
INSERT entities with a one to many relation with Bulk Operation.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    connection.BulkInsert(invoices).ThenBulkInsert(x => x.Items);
}
{% endhighlight %}
