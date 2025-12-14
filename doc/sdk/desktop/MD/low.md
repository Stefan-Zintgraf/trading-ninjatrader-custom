**Path**: [PriceSeries<double>](./priceseries.md) > [Low](./low.md)

# Low

# Low

## [Definition](./low.md)

A collection of historical bar low prices.

## [Property Value](./low.md)

An **ISeries`<double>`** type object. Accessing this property via an index value **int barsAgo** returns A **double** value representing the price of the referenced bar.

## [Syntax](./low.md)

`Low`

`Low[int barsAgo]`

## [Examples](./low.md)

```csharp
// Current bar low price
double barLowPrice = Low[0];

// Low price of 10 bars ago
double barLowPrice = Low[10];

// Current bar value of a 20 period exponential moving average of low prices**
double value = EMA(Low, 20)[0];

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./low.md)
*   [Property Value](./low.md)
*   [Syntax](./low.md)
*   [Examples](./low.md)