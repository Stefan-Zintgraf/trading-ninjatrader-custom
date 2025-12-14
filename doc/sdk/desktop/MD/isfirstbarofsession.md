**Path**: [Bars](./bars.md) > [IsFirstBarOfSession](./isfirstbarofsession.md)

# IsFirstBarOfSession

# IsFirstBarOfSession

## [Definition](./isfirstbarofsession.md)

Indicates if the current bar processing is the first bar updated in a trading session.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property always returns true on the very first bar processed (i.e., **CurrentBar** == 0). The represented time of the bar will NOT necessarily be equal to the trading hours start time (e.g., if you request 50 1\-minute bars at 11:50:00 AM, the first bar processed of the session would be 11:00:00 AM). Loading a data series based on "dates" (Days or custom range) ensures that the first bar processed matches hours defined by the session template.

## [Property Value](./isfirstbarofsession.md)

This property returns true if the bar is the first processed in a session; otherwise, false. This property is read\-only.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property will always return false on non\-intraday bar periods (e.g., Day, Month, etc). For checking for new non\-intraday bar updates, please see [IsFirstTickOfBar](./isfirsttickofbar.md).

## [Syntax](./isfirstbarofsession.md)

`Bars.IsFirstBarOfSession`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For checking at a specified bar index, please see [IsFirstBarOfSessionByIndex()](./isfirstbarofsessionbyindex.md).

## [Examples](./isfirstbarofsession.md)

```csharp
protected override void OnBarUpdate()
{
    // Print the current bar number of the first bar processed for each session on a chart
    if (Bars.IsFirstBarOfSession)
        Print(string.Format("Bar number {0} was the first bar processed of the session at {1}.", CurrentBar, Time[0]));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isfirstbarofsession.md)
*   [Property Value](./isfirstbarofsession.md)
*   [Syntax](./isfirstbarofsession.md)
*   [Examples](./isfirstbarofsession.md)