**Path**: [TradeCollection](./tradecollection.md) > [LosingTrades](./losingtrades.md)

# LosingTrades

# LosingTrades

## [Definition](./losingtrades.md)

A subcollection of **Trade** objects consisting of only the losing trades in a **TradeCollection**. You can access a trade object by providing an index value. Trades are indexed sequentially meaning the oldest trade taken in a strategy will be at an index value of zero. The most recent trade taken will be at an index value of the total trades in the collection minus 1.

## [Methods and Properties](./losingtrades.md)

[Count](./tradescount.md)

An **int** value representing the number of trades in the collection

[GetTrades()](./gettrades.md)

Gets a **TradeCollection** object representing a specified position

[TradesPerformance](./tradesperformance.md)

Gets a **TradesPerformance** object

## [Syntax](./losingtrades.md)

`<tradecollection>.LosingTrades`

## [Examples](./losingtrades.md)

```csharp
protected override void OnBarUpdate()
{
     // Accesses the first/last losing trade in the strategy (oldest trade is at index 0)
     // and prints out the profit as a percentage to the output window
     if (SystemPerformance.AllTrades.LosingTrades.Count > 1)
     {
         Trade lastTrade = SystemPerformance.AllTrades.LosingTrades[SystemPerformance.AllTrades.Count - 1];
         Trade firstTrade = SystemPerformance.AllTrades.LosingTrades[0];

         Print("The last losing trade's profit was " + lastTrade.ProfitPercent);
         Print("The first losing trade's profit was " + firstTrade.ProfitPercent);
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./losingtrades.md)
*   [Methods and Properties](./losingtrades.md)
*   [Syntax](./losingtrades.md)
*   [Examples](./losingtrades.md)