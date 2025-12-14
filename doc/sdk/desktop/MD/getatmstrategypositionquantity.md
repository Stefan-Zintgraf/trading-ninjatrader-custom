**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [GetAtmStrategyPositionQuantity()](./getatmstrategypositionquantity.md)

# GetAtmStrategyPositionQuantity()

# GetAtmStrategyPositionQuantity()

## [Definition](./getatmstrategypositionquantity.md)

Gets the current position quantity of the specified ATM Strategy.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Changes to positions will not be reflected till at least the next **OnBarUpdate()** event after an order fill.

## [Method Return Value](./getatmstrategypositionquantity.md)

An **int** value representing the quantity.

## [Syntax](./getatmstrategypositionquantity.md)

`GetAtmStrategyPositionQuantity(string atmStrategyId)`

## [Parameters](./getatmstrategypositionquantity.md)

**atmStrategyId**

The unique identifier for the ATM strategy

## [Examples](./getatmstrategypositionquantity.md)

```csharp
protected override void OnBarUpdate()
{
     // Check if flat
     if (GetAtmStrategyMarketPosition("idValue") != MarketPosition.Flat)
         Print("Position size is " + GetAtmStrategyPositionQuantity("idValue").ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getatmstrategypositionquantity.md)
*   [Method Return Value](./getatmstrategypositionquantity.md)
*   [Syntax](./getatmstrategypositionquantity.md)
*   [Parameters](./getatmstrategypositionquantity.md)
*   [Examples](./getatmstrategypositionquantity.md)