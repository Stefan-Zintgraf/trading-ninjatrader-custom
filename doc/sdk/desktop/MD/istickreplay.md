**Path**: [Bars](./bars.md) > [IsTickReplay](./istickreplay.md)

# IsTickReplay

# IsTickReplay

## [Definition](./istickreplay.md)

Indicates if the bar series is using the **Tick Replay** data series property.

## [Property Value](./istickreplay.md)

This property returns true if the bar series is using tick replay; otherwise, false. This property is read\-only.

## [Syntax](./istickreplay.md)

`Bars.IsTickReplay`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Warning: A Tick Replay indicator or strategy CANNOT use a **MarketDataType.Ask** or **MarketDataType.Bid** series. Please see [Developing for Tick Replay](./developing_for_tick_replay.md) for more information.

## [Examples](./istickreplay.md)

```csharp
private double askPrice;
protected override void OnMarketData(MarketDataEventArgs marketDataUpdate)
{
    if(Bars.IsTickReplay)
    {
        // if using tick replay, get the current ask price associated with the tick
        askPrice = marketDataUpdate.Ask;
    }
    else // otherwise, get the real-time market data price during MarketDataType.Ask event
        askPrice = marketDataUpdate.MarketDataType == MarketDataType.Ask ? marketDataUpdate.Price : double.MinValue;

    // only print if a value is set
    if(askPrice != double.MinValue)
    {
        Print("ask price: " + askPrice);
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./istickreplay.md)
*   [Property Value](./istickreplay.md)
*   [Syntax](./istickreplay.md)
*   [Examples](./istickreplay.md)