**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Darvas](./darvas.md)

# Darvas

# Darvas

## [Description](./darvas.md)

A trading strategy that was developed in 1956 by former ballroom dancer Nicolas Darvas. Darvas' trading technique involved buying into stocks that were trading at new 52\-week highs with correspondingly high volumes.

... Courtesy of [Investopedia](http://www.investopedia.com/terms/d/darvasboxtheory.asp)

## [Syntax](./darvas.md)

`Darvas()`

`Darvas(ISeries<double> input)`

**Returns the upper value**

`Darvas().Upper[int barsAgo]`

`Darvas(ISeries<double> input).Upper[int barsAgo]`

**Returns the lower value**

`Darvas().Lower[int barsAgo]`

`Darvas(ISeries<double> input).Lower[int barsAgo]`

## [Return Value](./darvas.md)

**double;** Accessing this method via an index value **\[int barsAgo\]** returns the indicator value of the referenced bar.

## [Parameters](./darvas.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

## [Examples](./darvas.md)

```csharp
// Prints the current upper Darvas value
double value = Darvas().Upper[0];
Print("The current upper Darvas value is " + value.ToString());

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Source Code](./darvas.md)

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.

#### ON THIS PAGE

*   [Description](./darvas.md)
*   [Syntax](./darvas.md)
*   [Return Value](./darvas.md)
*   [Parameters](./darvas.md)
*   [Examples](./darvas.md)
*   [Source Code](./darvas.md)