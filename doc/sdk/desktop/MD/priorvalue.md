**Path**: [Market Analyzer Column](./market_analyzer_column.md) > [PriorValue](./priorvalue.md)

# PriorValue

# PriorValue

## [Definition](./priorvalue.md)

Contains the last value of **CurrentValue**. **PriorValue** is assigned the value of **CurrentValue** immediately before **CurrentValue** is updated.

## [Property Value](./priorvalue.md)

A **double** containing the last value contained in [CurrentValue](./currentvalue.md) before its most recent update.

## [Syntax](./priorvalue.md)

`PriorValue`

## [Examples](./priorvalue.md)

```csharp
protected override void OnMarketData(MarketDataEventArgs marketDataUpdate)
{
   if (marketDataUpdate.MarketDataType == MarketDataType.Last)
   {
       CurrentValue = marketDataUpdate.Price;

       // Trigger an alert if the current Last price update is greater than the previous one
       if(CurrentValue > PriorValue)
           Alert("MA Alert", Priority.High, "Check Market Analyzer", "", 30, Brushes.Black, Brushes.White);
   }
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./priorvalue.md)
*   [Property Value](./priorvalue.md)
*   [Syntax](./priorvalue.md)
*   [Examples](./priorvalue.md)