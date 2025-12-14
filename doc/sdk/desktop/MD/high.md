**Path**: [PriceSeries<double>](./priceseries.md) > [High](./high.md)

# High

# High

## [Definition](./high.md)

A collection of historical bar high prices.

## [Property Value](./high.md)

An **ISeries`<double>`** type object. Accessing this property via an index value **int barsAgo** returns A **double** value representing the price of the referenced bar.

## [Syntax](./high.md)

`High`

`High[int barsAgo]`

## [Examples](./high.md)

```csharp
// OnBarUpdate method
protected override void OnBarUpdate()
{
     // Make sure we have at least 20 bars
     if (CurrentBar < 20)
         return;

     // Evaluates for higher highs
     if (High[0] > High[1] && High[1] > High[2])
         Print("Two successive higher highs");

     // Gets the current value of a 20 period SMA of high prices
     double value = SMA(High, 20)[0];
     Print("The value is " + value.ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

\\

#### ON THIS PAGE

*   [Definition](./high.md)
*   [Property Value](./high.md)
*   [Syntax](./high.md)
*   [Examples](./high.md)