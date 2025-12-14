**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [AtmStrategyClose()](./atmstrategyclose.md)

# AtmStrategyClose()

# AtmStrategyClose()

## [Definition](./atmstrategyclose.md)

Cancels any working orders and closes any open position of a strategy using the default [ATM strategy close behavior](https://ninjatrader.com/support/helpGuides/nt8/NT%20HelpGuide%20English.html?closing_a_position_or_atm_stra.htm).

## [Method Return Value](./atmstrategyclose.md)

Returns true if the specified ATM strategy was found; otherwise false.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

A method return value of true in NO WAY indicates that the strategy in fact is closed. It indicates that the the specified ATM strategy was found and the internal close routine was triggered.

## [Syntax](./atmstrategyclose.md)

`AtmStrategyClose(string atmStrategyId)`

## [Parameters](./atmstrategyclose.md)

atmStrategyId

The unique identifier for the ATM strategy

## [Examples](./atmstrategyclose.md)

```csharp
protected override void OnBarUpdate()
{
     // Check for valid condition and create an ATM Strategy
     if (GetAtmStrategyUnrealizedProfitLoss("idValue") > 500)
         AtmStrategyClose("idValue");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./atmstrategyclose.md)
*   [Method Return Value](./atmstrategyclose.md)
*   [Syntax](./atmstrategyclose.md)
*   [Parameters](./atmstrategyclose.md)
*   [Examples](./atmstrategyclose.md)