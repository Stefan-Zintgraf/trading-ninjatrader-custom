**Path**: [Analytical](./analytical.md) > [IsFalling()](./isfalling.md)

# IsFalling()

# IsFalling()

## [Definition](./isfalling.md)

Evaluates a falling condition which is true when the current value is less than the value of 1 bar ago.

## [Method Return Value](./isfalling.md)

This method returns true if a falling condition is present; otherwise, false.

## [Syntax](./isfalling.md)

`IsFalling(ISeries<double> series)`

## [Parameters](./isfalling.md)

**series**

Any **Series<`double`\>** type object such as an indicator, Close, High, Low, etc...

## [Examples](./isfalling.md)

```csharp
protected override void OnBarUpdate()
{
   // If the 20 period SMA is falling (in downtrend) go short
   if (IsFalling(SMA(20)))
       EnterShort();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isfalling.md)
*   [Method Return Value](./isfalling.md)
*   [Syntax](./isfalling.md)
*   [Parameters](./isfalling.md)
*   [Examples](./isfalling.md)