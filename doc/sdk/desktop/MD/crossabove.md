**Path**: [Analytical](./analytical.md) > [CrossAbove()](./crossabove.md)

# CrossAbove()

# CrossAbove()

## [Definition](./crossabove.md)

Evaluates a cross above condition over the specified bar look\-back period.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This method does not return true if both series being compared have equal values on the current or previous bar with a lookbackPeriod of 1.

## [Method Return Value](./crossabove.md)

This method returns true if a cross above condition occurred; otherwise, false.

## [Syntax](./crossabove.md)

`CrossAbove(ISeries<double> series1, ISeries<double> series2, int lookBackPeriod)`

`CrossAbove(ISeries<double> series1, double value, int lookBackPeriod)`

## [Parameters](./crossabove.md)

**lookBackPeriod**

Number of bars back to check the cross above condition

**series1** & **series2**

Any **Series<`double`\>** type object such as an indicator, Close, High, Low, etc...

**value**

Any **double** value

## [Examples](./crossabove.md)

```csharp
protected override void OnBarUpdate()
{
   // Go short if CCI crossed above 250 within the last bar
   if (CrossAbove(CCI(14), 250, 1))
       EnterShort();

   // Go long if 10 EMA crosses above 20 EMA within the last bar
   if (CrossAbove(EMA(10), EMA(20), 1))
       EnterLong();

   // Go long we have an up bar and the 10 EMA crosses above 20 EMA within the last 5 bars
   if (Close[0] > Open[0] && CrossAbove(EMA(10), EMA(20), 5))
       EnterLong();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./crossabove.md)
*   [Method Return Value](./crossabove.md)
*   [Syntax](./crossabove.md)
*   [Parameters](./crossabove.md)
*   [Examples](./crossabove.md)