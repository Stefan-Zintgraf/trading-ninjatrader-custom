**Path**: [Analytical](./analytical.md) > [IsRising()](./isrising.md)

# IsRising()

# IsRising()

## [Definition](./isrising.md)

Evaluates a rising condition which is true when the current value is greater than the value of 1 bar ago.

## [Method Return Value](./isrising.md)

This method returns true if a rising condition is present; otherwise, false.

## [Syntax](./isrising.md)

`IsRising(ISeries<double> series)`

## [Parameters](./isrising.md)

Parameter

Description

**series**

Any **Series<`double`\>** type object such as an indicator, Close, High, Low, etc...

## [Examples](./isrising.md)

```csharp
protected override void OnBarUpdate()
{
   // If the 20 period SMA is rising (in uptrend) go long
   if (IsRising(SMA(20)))
       EnterLong();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isrising.md)
*   [Method Return Value](./isrising.md)
*   [Syntax](./isrising.md)
*   [Parameters](./isrising.md)
*   [Examples](./isrising.md)