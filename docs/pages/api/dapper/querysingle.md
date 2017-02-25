---
layout: default
title: Dapper - QuerySingle 
permalink: querysingle
---

{% include template-h1.html %}

## Description
Execute a query and map the first result, and throws an exception if there is not exactly one element in the sequence.

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
Execute a query and map the first result to a dynamic list, and throws an exception if there is not exactly one element in the sequence.

{% highlight csharp %}
example
{% endhighlight %}

## Example - Query Strongly Typed
Execute a query and map the first result to a strongly typed list, and throws an exception if there is not exactly one element in the sequence.

{% highlight csharp %}
example
{% endhighlight %}
