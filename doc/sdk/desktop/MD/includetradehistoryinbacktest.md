**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [IncludeTradeHistoryInBacktest](./includetradehistoryinbacktest.md)

# IncludeTradeHistoryInBacktest

# IncludeTradeHistoryInBacktest

## [Definition](./includetradehistoryinbacktest.md)

Determines if the strategy will save orders, trades, and execution history. When this property is set to false you will see significant memory savings at the expense of having access to the detailed trading information.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   Since trade information is not stored you will only see entry/exit executions plotted on the chart with no connecting PnL trade lines.
    
*   This property is always defaulted to true, except when the strategy is running on the strategy tab.
    

## [Property Value](./includetradehistoryinbacktest.md)

This property returns true if the strategy will include trade history; otherwise, false. Default is set to true.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during State.Configure (or State.SetDefaults when adding the script from the strategy tab).

## [Syntax](./includetradehistoryinbacktest.md)

`IncludeTradeHistoryInBacktest`

## [Examples](./includetradehistoryinbacktest.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.Configure)
    {
        // Exclude trade history in a backtest to benefit from memory savings
        IncludeTradeHistoryInBacktest = false;
    }
}

protected override void OnBarUpdate()
{
    // Stop taking trades after 10 trades have been taken since the strategy was enabled
    if(SystemPerformance.AllTrades.Count >= 10)
        return;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./includetradehistoryinbacktest.md)
*   [Property Value](./includetradehistoryinbacktest.md)
*   [Syntax](./includetradehistoryinbacktest.md)
*   [Examples](./includetradehistoryinbacktest.md)