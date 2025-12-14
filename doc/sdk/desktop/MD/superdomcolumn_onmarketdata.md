**Path**: [SuperDOM Column](./superdom_column.md) > [OnMarketData()](./superdomcolumn_onmarketdata.md)

# OnMarketData()

# OnMarketData()

## [Definition](./superdomcolumn_onmarketdata.md)

Called and guaranteed to be in the correct sequence for every change in level one market data for the underlying instrument. The OnMarketData() method updates can include but is not limited to the bid, ask, last price and volume.

## [Method Return Value](./superdomcolumn_onmarketdata.md)

This method does not return a value.

## [Syntax](./superdomcolumn_onmarketdata.md)

`protected override void OnMarketData(MarketDataEventArgs marketDataUpdate) { }`

## [Parameters](./superdomcolumn_onmarketdata.md)

marketDataUpdate

A [MarketDataEventArgs](./marketdataeventargs.md) representing the change in market data

## [Examples](./superdomcolumn_onmarketdata.md)

```csharp
protected override void OnMarketData(MarketDataEventArgs marketDataUpdate)
{
  if (marketDataUpdate.MarketDataType == Data.MarketDataType.Last)
  {
    // Do something
  }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./superdomcolumn_onmarketdata.md)
*   [Method Return Value](./superdomcolumn_onmarketdata.md)
*   [Syntax](./superdomcolumn_onmarketdata.md)
*   [Parameters](./superdomcolumn_onmarketdata.md)
*   [Examples](./superdomcolumn_onmarketdata.md)