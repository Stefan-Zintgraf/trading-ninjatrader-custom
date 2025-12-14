**Path**: [PriceSeries<double>](./priceseries.md) > [Median](./median.md)

# Median

# Median

## [Definition](./median.md)

A collection of historical bar median prices. Median price = (High + Low) / 2.

## [Property Value](./median.md)

An **ISeries`<double>`** type object. Accessing this property via an index value **int barsAgo** returns A **double** value representing the price of the referenced bar.

## [Syntax](./median.md)

`Median`

`Median[int barsAgo]`

## [Examples](./median.md)

```csharp

//Current bar median price
double barMedianPrice = Median[0];

//  Median price of 10 bars ago
double barMedianPrice = Median[10];

// Current bar value of a 20 period exponential moving average of median prices
double value = EMA(Median, 20)[0];

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./median.md)
*   [Property Value](./median.md)
*   [Syntax](./median.md)
*   [Examples](./median.md)