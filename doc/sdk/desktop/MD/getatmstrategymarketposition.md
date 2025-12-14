**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [GetAtmStrategyMarketPosition()](./getatmstrategymarketposition.md)

# GetAtmStrategyMarketPosition()

# GetAtmStrategyMarketPosition()

## [Definition](./getatmstrategymarketposition.md)

Gets the current market position of the specified ATM Strategy.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Notes:

1.  Changes to positions will not be reflected till at least the next **OnBarUpdate()** event after an order fill.
2.  If the ATM Strategy does not exist then **MarketPosition.Flat** returns.
3.  Please note this provides access to the current ATM strategy position, which should not be confused with the NinjaScript strategy position or account position. For more information please see the [Using ATM Strategies](./using_atm_strategies.md) section.

## [Method Return Value](./getatmstrategymarketposition.md)

*   **MarketPosition.Flat**
*   **MarketPosition.Long**
*   **MarketPosition.Short**

## [Syntax](./getatmstrategymarketposition.md)

`GetAtmStrategyMarketPosition(string atmStrategyId)`

## [Parameters](./getatmstrategymarketposition.md)

**atmStrategyId**

The unique identifier for the ATM strategy

## [Examples](./getatmstrategymarketposition.md)

```csharp
protected override void OnBarUpdate()
{
    // Check if flat
    if (GetAtmStrategyMarketPosition("id") == MarketPosition.Flat)
        Print("ATM Strategy position is currently flat");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getatmstrategymarketposition.md)
*   [Method Return Value](./getatmstrategymarketposition.md)
*   [Syntax](./getatmstrategymarketposition.md)
*   [Parameters](./getatmstrategymarketposition.md)
*   [Examples](./getatmstrategymarketposition.md)