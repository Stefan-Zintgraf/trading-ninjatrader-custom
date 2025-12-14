**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [AtmStrategyChangeEntryOrder()](./atmstrategychangeentryorder.md)

# AtmStrategyChangeEntryOrder()

# AtmStrategyChangeEntryOrder()

## [Definition](./atmstrategychangeentryorder.md)

Changes the price of the specified entry order.

## [Method Return Value](./atmstrategychangeentryorder.md)

Returns true if the specified order was found; otherwise false.

## [Syntax](./atmstrategychangeentryorder.md)

`AtmStrategyChangeEntryOrder(double limitPrice, double stopPrice, string orderId)`

## [Parameters](./atmstrategychangeentryorder.md)

limitPrice

Order limit price

stopPrice

Order stop price

orderId

The unique identifier for the entry order

## [Examples](./atmstrategychangeentryorder.md)

```csharp
protected override void OnBarUpdate()
{
     AtmStrategyChangeEntryOrder(GetCurrentBid(), 0, "orderIdValue");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./atmstrategychangeentryorder.md)
*   [Method Return Value](./atmstrategychangeentryorder.md)
*   [Syntax](./atmstrategychangeentryorder.md)
*   [Parameters](./atmstrategychangeentryorder.md)
*   [Examples](./atmstrategychangeentryorder.md)