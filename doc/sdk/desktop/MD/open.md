**Path**: [PriceSeries<double>](./priceseries.md) > [Open](./open.md)

# Open

# Open

## [Definition](./open.md)

A collection of historical bar opening prices.

## [Property Value](./open.md)

An **ISeries`<double>`** type object. Accessing this property via an index value `[int barsAgo]` returns A **double** value representing the price of the referenced bar.

## [Syntax](./open.md)

`Open`

`Open[int barsAgo]`

## [Examples](./open.md)

```csharp
//Current bar opening price
double barOpenPrice = Open[0];

// Opening price of 10 bars ago
double barOpenPrice = Open[10];

//Current bar value of a 20 period simple moving average of opening prices
double value = SMA(Open, 20)[0];

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./open.md)
*   [Property Value](./open.md)
*   [Syntax](./open.md)
*   [Examples](./open.md)