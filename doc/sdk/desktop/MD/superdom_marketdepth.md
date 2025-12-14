**Path**: [SuperDOM Column](./superdom_column.md) > [MarketDepth](./superdom_marketdepth.md)

# MarketDepth

# MarketDepth

## [Definition](./superdom_marketdepth.md)

The **OnMarketDepth()** method is called and guaranteed to be in the correct sequence for every change in level two market data (market depth) for the underlying instrument.

## [Method Return Value](./superdom_marketdepth.md)

This method does not return a value.

## [Syntax](./superdom_marketdepth.md)

`MarketDepth`

## [Examples](./superdom_marketdepth.md)

```csharp
protected override void OnMarketDepth(Data.MarketDepthEventArgs marketDepthUpdate)

{
    if (marketDepthUpdate.MarketDataType == MarketDataType.Ask && marketDepthUpdate.Operation == Operation.Update)
        // Do something
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./superdom_marketdepth.md)
*   [Method Return Value](./superdom_marketdepth.md)
*   [Syntax](./superdom_marketdepth.md)
*   [Examples](./superdom_marketdepth.md)