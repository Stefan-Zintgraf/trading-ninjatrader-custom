**Path**: [Bars](./bars.md) > [IsFirstBarOfSessionByIndex()](./isfirstbarofsessionbyindex.md)

# IsFirstBarOfSessionByIndex()

# IsFirstBarOfSessionByIndex()

## [Definition](./isfirstbarofsessionbyindex.md)

Indicates if the selected bar index value is the first bar of a trading session.

## [Property Value](./isfirstbarofsessionbyindex.md)

This property returns true if the bar is the first bar of a session; otherwise, false. This property is read\-only.

## [Syntax](./isfirstbarofsessionbyindex.md)

`Bars.IsFirstBarOfSessionByIndex(int index)`

## [Warning](./isfirstbarofsessionbyindex.md)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property will always return false on non\-intraday bar periods (e.g., Day, Month, etc).

## [Parameters](./isfirstbarofsessionbyindex.md)

**index**

An int representing an absolute bar index value

## [Examples](./isfirstbarofsessionbyindex.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    base.OnRender(chartControl, chartScale);
    // loop through only the rendered bars on the chart 
    for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)
    {
        // check if the rendered bar is the first bar of the trading session
        if (Bars.IsFirstBarOfSessionByIndex(barIndex))
        {
            DateTime slotTimeAtBarIndex = chartControl.GetTimeBySlotIndex(barIndex);
            Print(string.Format("Bar index {0} was the first bar of the session at slot time {1}.", barIndex, slotTimeAtBarIndex));
        }
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isfirstbarofsessionbyindex.md)
*   [Property Value](./isfirstbarofsessionbyindex.md)
*   [Syntax](./isfirstbarofsessionbyindex.md)
*   [Warning](./isfirstbarofsessionbyindex.md)
*   [Parameters](./isfirstbarofsessionbyindex.md)
*   [Examples](./isfirstbarofsessionbyindex.md)