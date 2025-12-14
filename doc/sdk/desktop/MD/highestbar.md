**Path**: [Analytical](./analytical.md) > [HighestBar()](./highestbar.md)

# HighestBar()

# HighestBar()

## [Definition](./highestbar.md)

Returns the number of bars ago the highest price value occurred within the specified look\-back period.

## [Method Return Value](./highestbar.md)

An **int** value representing a value of bars ago.

## [Syntax](./highestbar.md)

`HighestBar(ISeries<double> series, int period)`

## [Parameters](./highestbar.md)

**period**

The number of bars to include in the calculation

**series**

Any **Series<`double`\>** type object such as an indicator, Close, High, Low, etc...

## [Examples](./highestbar.md)

```csharp
protected override void OnBarUpdate()
{
   // store the highest bars ago value
   int highestBarsAgo = HighestBar(**High, Bars.BarsSinceNewTradingDay);

   //evaluate high price from highest bars ago value
   double highestPrice = High[highestBarsAgo];

   //Printed result:  Highest price of the session: 2095.5 - occurred 24 bars ago
   Print(string.Format("Highest price of the session: {0} - occurred {1} bars ago", highestPrice, highestBarsAgo));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./highestbar.md)
*   [Method Return Value](./highestbar.md)
*   [Syntax](./highestbar.md)
*   [Parameters](./highestbar.md)
*   [Examples](./highestbar.md)