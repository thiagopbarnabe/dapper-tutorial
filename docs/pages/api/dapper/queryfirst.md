---
layout: default
title: Dapper - QueryFirst 
permalink: queryfirst
---

{% include template-h1.html %}

## Description
Execute a query and map the first result.

The result can be mapped to:

- [Anonymous](#example---query-anonymous)
- [Strongly Typed](#example---query-strongly-typed)

### First, Single & Default

| Result          | None      | Single | Many       |
| :-------------- | :-------: | :----: | :--------: |
| First           | Exception | Item   | First Item |
| FirstOrDefault  | Default   | Item   | First Item |
| Single          | Exception | Item   | Exception  |
| SingleOrDefault | Default   | Item   | Exception  |

## Example - Query Anonymous
Execute a query and map the first result to a dynamic list.

{% highlight csharp %}
example
{% endhighlight %}

## Example - Query Strongly Typed
Execute a query and map the first result to a strongly typed list.

{% highlight csharp %}
example
{% endhighlight %}
