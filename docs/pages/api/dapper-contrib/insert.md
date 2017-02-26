---
layout: default
title: Dapper Contrib - Insert
permalink: insert
---

{% include template-h1.html %}

## Description
INSERT a single or many entities.

- [Insert Single](#example---insert-single)
- [Insert Many](#example---insert-single)

## Example - Insert Single
INSERT a single entitiy.

{% highlight csharp %}
using (var connection = My.ConnectionFactory())
{
    connection.Open();

    var isSuccess = connection.Insert(new Invoice { Code = "Insert_Single_1" });
}
{% endhighlight %}

## Example - Insert Many
INSERT many entities.

{% highlight csharp %}
example
{% endhighlight %}
