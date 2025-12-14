**Path**: [Bars Type](./bars_type.md) > [AddBar()](./addbar.md)

# AddBar()

# AddBar()

## [Definition](./addbar.md)

Adds new data points for the Bars Type.

## [Syntax](./addbar.md)

`AddBar(Bars bars, double open, double high, double low, double close, DateTime time, long volume)`

`AddBar(Bars bars, double open, double high, double low, double close, DateTime time, long volume, double bid, double ask)`

## [Parameters](./addbar.md)

bars

The Bars object of your bars type

open

A **double** value representing the open price

high

A **double** value representing the high price

low

A **double** value representing the low price

close

A **double** value representing the close price

time

A **DateTime** value representing the time

volume

A **long** value representing the volume

bid

A **double** value representing the bid price

ask

A **double** value representing the ask price

## [Examples](./addbar.md)

```csharp
AddBar(bars, open, high, low, close, time, (long)Math.Min(volumeTmp, bars.BarsPeriod.Value));

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./addbar.md)
*   [Syntax](./addbar.md)
*   [Parameters](./addbar.md)
*   [Examples](./addbar.md)