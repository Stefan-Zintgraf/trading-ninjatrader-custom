**Path**: [PriceSeries<double>](./priceseries.md) > [Typical](./typical.md)

# Typical

# Typical

## [Definition](./typical.md)

A collection of historical bar typical prices. Typical price = (High + Low + Close) / 3.

## [Property Value](./typical.md)

An **ISeries<`double`\>** type object. Accessing this property via an index value `[int barsAgo]` returns a double value representing the price of the referenced bar.

## [Syntax](./typical.md)

`Typical`

`Typical[int barsAgo]`

## [Examples](./typical.md)

```csharp
// Current bar typical price  
double barTypicalPrice = Typical[0];  
   
// Typical price of 10 bars ago  
double barTypicalPrice = Typical[10];  
   
// Current bar value of a 20 period exponential moving average of typical prices  
double value = EMA(Typical, 20)[0];

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./typical.md)
*   [Property Value](./typical.md)
*   [Syntax](./typical.md)
*   [Examples](./typical.md)