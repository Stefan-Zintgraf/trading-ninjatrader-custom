**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [GetAtmStrategyPositionAveragePrice()](./getatmstrategypositionaverageprice.md)

# GetAtmStrategyPositionAveragePrice()

# GetAtmStrategyPositionAveragePrice()

## [Definition](./getatmstrategypositionaverageprice.md)

Gets the current position's average price of the specified ATM Strategy.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Changes to positions will not be reflected till at least the next **OnBarUpdate()** event after an order fill.

## [Method Return Value](./getatmstrategypositionaverageprice.md)

A **double** value representing the average price.

## [Syntax](./getatmstrategypositionaverageprice.md)

`GetAtmStrategyPositionAveragePrice(string atmStrategyId)`

## [Parameters](./getatmstrategypositionaverageprice.md)

**atmStrategyId**

The unique identifier for the ATM strategy

## [Examples](./getatmstrategypositionaverageprice.md)

```csharp
protected override void OnBarUpdate()
{
     // Check if flat
     if (GetAtmStrategyMarketPosition("id") != MarketPosition.Flat)
         Print("Average price is " + GetAtmStrategyPositionAveragePrice("id").ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getatmstrategypositionaverageprice.md)
*   [Method Return Value](./getatmstrategypositionaverageprice.md)
*   [Syntax](./getatmstrategypositionaverageprice.md)
*   [Parameters](./getatmstrategypositionaverageprice.md)
*   [Examples](./getatmstrategypositionaverageprice.md)