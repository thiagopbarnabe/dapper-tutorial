---
layout: default
title: Dapper - QueryFirstOrDefault
permalink: queryfirstordefault
---

{% include template-h1.html %}

## Description
Execute a query and map the first result, or a default value if the sequence contains no elements.

The result can be mapped to:

- [Anonymous](#example---query-anonymous)
- [Strongly Typed](#example---query-strongly-typed)

### First, Single & Default
Be careful to use the right method. First & Single methods are very different.

| Result          | No Item   | One Item | Many Items |
| :-------------- | :-------: | :------: | :--------: |
| First           | Exception | Item     | First Item |
| Single          | Exception | Item     | Exception  |
| FirstOrDefault  | Default   | Item     | First Item |
| SingleOrDefault | Default   | Item     | Exception  |

## Example - Query Anonymous
Execute a query and map the first result to a dynamic list, or a default value if the sequence contains no elements.

{% highlight csharp %}
example
{% endhighlight %}

## Example - Query Strongly Typed
Execute a query and map the first result to a strongly typed list, or a default value if the sequence contains no elements.

{% highlight csharp %}
example
{% endhighlight %}
