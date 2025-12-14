**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [GetAtmStrategyRealizedProfitLoss()](./getatmstrategyrealizedprofitloss.md)

# GetAtmStrategyRealizedProfitLoss()

# GetAtmStrategyRealizedProfitLoss()

## [Definition](./getatmstrategyrealizedprofitloss.md)

Gets the realized profit and loss value of the specified ATM Strategy.

## [Method Return Value](./getatmstrategyrealizedprofitloss.md)

A **double** value representing the realized profit and loss.

## [Syntax](./getatmstrategyrealizedprofitloss.md)

`GetAtmStrategyRealizedProfitLoss(string atmStrategyId)`

## [Parameters](./getatmstrategyrealizedprofitloss.md)

**atmStrategyId**

The unique identifier for the ATM strategy

## [Examples](./getatmstrategyrealizedprofitloss.md)

```csharp
protected override void OnBarUpdate()
{
     Print("PnL is " + GetAtmStrategyRealizedProfitLoss("id").ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getatmstrategyrealizedprofitloss.md)
*   [Method Return Value](./getatmstrategyrealizedprofitloss.md)
*   [Syntax](./getatmstrategyrealizedprofitloss.md)
*   [Parameters](./getatmstrategyrealizedprofitloss.md)
*   [Examples](./getatmstrategyrealizedprofitloss.md)