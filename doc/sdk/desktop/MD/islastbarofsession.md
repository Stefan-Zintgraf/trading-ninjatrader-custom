**Path**: [Bars](./bars.md) > [IsLastBarOfSession](./islastbarofsession.md)

# IsLastBarOfSession

# IsLastBarOfSession

## [Definition](./islastbarofsession.md)

Indicates if the current bar processing is the last bar updated in a trading session.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Notes:

*   This property will always return false on non\-intraday bar periods (e.g., Day, Month, etc.)
*   When running Calculate.OnEachTick / OnPriceChange, this property will always return true on the most current real\-time bar since it is the last bar that is updating in the trading session. If you need to find a bar which coincides with the session end time, please use the **SessionIterator.ActualSessionEnd**.

## [Property Value](./islastbarofsession.md)

This property returns true if the bar is the last processed in a session; otherwise, false. This property is read\-only.

## [Syntax](./islastbarofsession.md)

`Bars.IsLastBarOfSession`

## [Examples](./islastbarofsession.md)

```csharp
protected override void OnBarUpdate()
{
    // Print the current bar number of the first bar processed for each session on a chart
    if(Bars.IsLastBarOfSession)
        Print(string.Format("Bar number {0} was the last bar processed of the session at {1}.", CurrentBar, Time[0]));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./islastbarofsession.md)
*   [Property Value](./islastbarofsession.md)
*   [Syntax](./islastbarofsession.md)
*   [Examples](./islastbarofsession.md)