**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [AtmStrategyCancelEntryOrder()](./atmstrategycancelentryorder.md)

# AtmStrategyCancelEntryOrder()

# AtmStrategyCancelEntryOrder()

## [Definition](./atmstrategycancelentryorder.md)

Cancels the specified entry order determined by the string "orderId" parameter.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  This method is intended ONLY for orders submitted as [Atm Entry Orders](./atmstrategycreate.md) and assumes the [OrderState](./getatmstrategyentryorderstatus.md) is NOT terminal (i.e., Cancelled, Filled, Rejected, Unknown).
2.  If the specified order does not exist, the method returns false and an error is logged.

## [Method Return Value](./atmstrategycancelentryorder.md)

Returns true if the specified order was found; otherwise false.

## [Syntax](./atmstrategycancelentryorder.md)

`AtmStrategyCancelEntryOrder(string orderId)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This method should ONLY be called once the strategy [State](./state.md) has reached State.Realtime

## [Parameters](./atmstrategycancelentryorder.md)

orderId

The unique identifier for the entry order

## [Examples](./atmstrategycancelentryorder.md)

```csharp
protected override void OnBarUpdate()
{
   // ATM strategy methods only work during real-time
   if (State != State.Realtime)
     return;
 
   string[] entryOrder = GetAtmStrategyEntryOrderStatus("orderId");
 
   // checks if the entry order exists
   // and the order state is not already cancelled/filled/rejected
   if (entryOrder.Length > 0 && entryOrder[2] == "Working")
   {
     AtmStrategyCancelEntryOrder("orderId");
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./atmstrategycancelentryorder.md)
*   [Method Return Value](./atmstrategycancelentryorder.md)
*   [Syntax](./atmstrategycancelentryorder.md)
*   [Parameters](./atmstrategycancelentryorder.md)
*   [Examples](./atmstrategycancelentryorder.md)