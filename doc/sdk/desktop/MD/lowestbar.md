**Path**: [Analytical](./analytical.md) > [LowestBar()](./lowestbar.md)

# LowestBar()

# LowestBar()

## [Definition](./lowestbar.md)

Returns the number of bars ago the lowest price value occurred within the specified look\-back period.

## [Method Return Value](./lowestbar.md)

An **int** value representing a value of bars ago.

## [Syntax](./lowestbar.md)

`LowestBar(ISeries<double> series, int period)`

## [Parameters](./lowestbar.md)

**period**

The number of bars to check for the test condition

**series**

Any **Series<`double`\>** type object such as an indicator, **Close**, **High**, **Low**, etc...

## [Examples](./lowestbar.md)

```csharp
protected override void OnBarUpdate()
{
   // store the lowest bar ago value
   int lowestBar = LowestBar(Low, Bars.BarsSinceNewTradingDay);

   //evaluate low price from lowest bar ago value
   double lowestPrice = Low[lowestBar];

   //Printed result:  Lowest price of the session: 2087.25 - occurred 362 bars ago
   Print(string.Format("Lowest price of the session: {0} - occurred {1} bars ago", lowestPrice, lowestBar));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./lowestbar.md)
*   [Method Return Value](./lowestbar.md)
*   [Syntax](./lowestbar.md)
*   [Parameters](./lowestbar.md)
*   [Examples](./lowestbar.md)