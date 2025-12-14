**Path**: [Market Analyzer Column](./market_analyzer_column.md) > [CurrentText](./currenttext.md)

# CurrentText

# CurrentText

## [Definition](./currenttext.md)

Sets text to be displayed in the Market Analyzer column.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

**CurrentText** will overrule any value set for [**CurrentValue**](./currentvalue.md). If both **CurrentValue** and **CurrentText** have assigned values, the value of **CurrentText** will display in the column.

## [Property Value](./currenttext.md)

A string representing text to display in the column.

## [Syntax](./currenttext.md)

`CurrentText`

## [Examples](./currenttext.md)

```csharp
protected override void OnMarketData(MarketDataEventArgs marketDataUpdate)
{
   // Print "Ask" in the column if an Ask price update is received
   if(marketDataUpdate.MarketDataType == MarketDataType.Ask)
       CurrentText = "Ask";
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./currenttext.md)
*   [Property Value](./currenttext.md)
*   [Syntax](./currenttext.md)
*   [Examples](./currenttext.md)