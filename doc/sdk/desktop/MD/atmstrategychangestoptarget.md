**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [AtmStrategyChangeStopTarget()](./atmstrategychangestoptarget.md)

# AtmStrategyChangeStopTarget()

# AtmStrategyChangeStopTarget()

## [Definition](./atmstrategychangestoptarget.md)

Changes the price of the specified order of the specified ATM strategy.

## [Method Return Value](./atmstrategychangestoptarget.md)

Returns true if the specified order was found; otherwise false.

## [Syntax](./atmstrategychangestoptarget.md)

`AtmStrategyChangeStopTarget(double limitPrice, double stopPrice, string orderName, string atmStrategyId)`

## [Parameters](./atmstrategychangestoptarget.md)

limitPrice

Order limit price

stopPrice

Order stop price

orderName

The order name such as "Stop1" or "Target2"

atmStrategyId

The unique identifier for the ATM strategy

## [Examples](./atmstrategychangestoptarget.md)

```csharp
protected override void OnBarUpdate()
{
     AtmStrategyChangeStopTarget(0, SMA(10)[0], "Stop1", "AtmIdValue");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./atmstrategychangestoptarget.md)
*   [Method Return Value](./atmstrategychangestoptarget.md)
*   [Syntax](./atmstrategychangestoptarget.md)
*   [Parameters](./atmstrategychangestoptarget.md)
*   [Examples](./atmstrategychangestoptarget.md)