---
layout: default
title: Dapper Contrib
permalink: dapper-contrib
---

{% include template-h1.html %}


## What's Dapper Contrib?
Dapper Contrib extend the IDbConnection interface with additional CRUD methods.

## Installation
Dapper Contrib is installed through NuGet: <a href="https://www.nuget.org/packages/Dapper.Contrib/" target="_blank">https://www.nuget.org/packages/Dapper.Contrib/</a>

## Methods
Dapper Contrib extend your IDbConnection interface with additional CRUD methods:

- [Get](/get)
- [GetAll](/getall)
- [Insert](/insert)
- [Update](/update)
- [Delete](/delete)
- [DeleteAll](/deleteall)

{% highlight csharp %}
example
{% endhighlight %}


## Data Annotations
Dapper Contrib allow mapping using Data Annotations:

- [Key](data-annotation-key)
- [ExplicitKey](data-annotation-explicitkey)
- [Table](data-annotation-table)
- [Write](data-annotation-write)
- [Computed](data-annotation-computed)
