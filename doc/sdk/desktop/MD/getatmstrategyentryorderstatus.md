**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [GetAtmStrategyEntryOrderStatus()](./getatmstrategyentryorderstatus.md)

# GetAtmStrategyEntryOrderStatus()

# GetAtmStrategyEntryOrderStatus()

## [Definition](./getatmstrategyentryorderstatus.md)

Gets the current state of the specified entry order.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

If the method can't find the specified order, an empty array is returned.

## [Method Return Value](./getatmstrategyentryorderstatus.md)

A string\[\] array holding three elements that represent average fill price, filled amount and order state.

## [Syntax](./getatmstrategyentryorderstatus.md)

`GetAtmStrategyEntryOrderStatus(string orderId)`

## [Parameters](./getatmstrategyentryorderstatus.md)

**orderId**

The unique identifier for the entry order

## [Examples](./getatmstrategyentryorderstatus.md)

```csharp
protected override void OnBarUpdate()
{
     string[] entryOrder = GetAtmStrategyEntryOrderStatus("orderId");

     // Check length to ensure that returned array holds order information
     if (entryOrder.Length > 0)
     {
         Print("Average fill price is " + entryOrder[0].ToString());
         Print("Filled amount is " + entryOrder[1].ToString());
         Print("Current state is " + entryOrder[2].ToString());
     }


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getatmstrategyentryorderstatus.md)
*   [Method Return Value](./getatmstrategyentryorderstatus.md)
*   [Syntax](./getatmstrategyentryorderstatus.md)
*   [Parameters](./getatmstrategyentryorderstatus.md)
*   [Examples](./getatmstrategyentryorderstatus.md)