**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [GetAtmStrategyUnrealizedProfitLoss()](./getatmstrategyunrealizedprofitloss.md)

# GetAtmStrategyUnrealizedProfitLoss()

# GetAtmStrategyUnrealizedProfitLoss()

## [Definition](./getatmstrategyunrealizedprofitloss.md)

Gets the unrealized profit and loss value of the specified ATM Strategy.

## [Method Return Value](./getatmstrategyunrealizedprofitloss.md)

A **double** value representing the unrealized profit and loss.

## [Syntax](./getatmstrategyunrealizedprofitloss.md)

`GetAtmStrategyUnrealizedProfitLoss(string atmStrategyId)`

## [Parameters](./getatmstrategyunrealizedprofitloss.md)

**atmStrategyId**

The unique identifier for the ATM strategy

## [Examples](./getatmstrategyunrealizedprofitloss.md)

```csharp
protected override void OnBarUpdate()
{
     Print("Unrealized PnL is " + GetAtmStrategyUnrealizedProfitLoss("id").ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getatmstrategyunrealizedprofitloss.md)
*   [Method Return Value](./getatmstrategyunrealizedprofitloss.md)
*   [Syntax](./getatmstrategyunrealizedprofitloss.md)
*   [Parameters](./getatmstrategyunrealizedprofitloss.md)
*   [Examples](./getatmstrategyunrealizedprofitloss.md)