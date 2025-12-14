**Path**: [PriceSeries<double>](./priceseries.md) > [Weighted](./weighted.md)

# Weighted

# Weighted

## [Definition](./weighted.md)

A collection of historical bar weighted prices. Weighted price = `(High + Low + Close + Close) / 4`.

## [Property Value](./weighted.md)

An **ISeries<`double`\>** type object. Accessing this property via an index value `[int barsAgo]` returns a double value representing the price of the referenced bar.

## [Syntax](./weighted.md)

`Weighted`

`Weighted[int barsAgo]`

## [Examples](./weighted.md)

```csharp
// Current bar weighted price
double barWeigthedPrice = Weighted[0];

// Weighted price of 10 bars ago
double barWeigthedPrice = Weighted[10];

// Current bar value of a 20 period exponential moving average of weighted prices
double value = EMA(Weighted, 20)[0];

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./weighted.md)
*   [Property Value](./weighted.md)
*   [Syntax](./weighted.md)
*   [Examples](./weighted.md)