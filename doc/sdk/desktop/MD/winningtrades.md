**Path**: [TradesPerformance](./tradesperformance.md) > [WinningTrades](./winningtrades.md)

# WinningTrades

# WinningTrades

## [Definition](./winningtrades.md)

A subcollection of [Trade](./trade.md) objects consisting of only the winning trades in a [TradeCollection](./tradecollection.md). You can access a trade object by providing an index value. Trades are indexed sequentially meaning the oldest trade taken in a strategy will be at an index value of zero. The most recent trade taken will be at an index value of the total trades in the collection minus 1.

## [Methods and Properties](./winningtrades.md)

Method/Property

Description

[Count](./tradescount.md)

An int value representing the number of trades in the collection

[GetTrades()](./gettrades.md)

Gets a [TradeCollection](./tradecollection.md) object representing a specified position

[TradesPerformance](./tradesperformance.md)

Gets a [TradesPerformance](./tradesperformance.md) object

## [Syntax](./winningtrades.md)

`<TradeCollection>.WinningTrades`

## [Examples](./winningtrades.md)

```csharp
protected override void OnBarUpdate()  
{  
    // Accesses the first/last winning trade in the strategy (oldest trade is at index 0)  
    // and prints out the profit as a percentage to the output window  
    if (SystemPerformance.AllTrades.WinningTrades.Count > 1)  
    {  
        Trade lastTrade = SystemPerformance.AllTrades.WinningTrades[SystemPerformance.AllTrades.Count - 1];  
        Trade firstTrade = SystemPerformance.AllTrades.WinningTrades[0];  
   
        Print("The last winning trade's profit was " + lastTrade.ProfitPercent);  
        Print("The first winning trade's profit was " + firstTrade.ProfitPercent);  
    }  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./winningtrades.md)
*   [Methods and Properties](./winningtrades.md)
*   [Syntax](./winningtrades.md)
*   [Examples](./winningtrades.md)