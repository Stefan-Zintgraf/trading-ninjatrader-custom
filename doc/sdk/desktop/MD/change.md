**Path**: [Account Class](./account_class.md) > [Change()](./change.md)

# Change()

# Change()

## [Definition](./change.md)

Changes specified **Order** object(s).

## [Syntax](./change.md)

`Change(IEnumerable<`order`> orders)`

## [Parameters](./change.md)

orders

Order(s) to change

## [Examples](./change.md)

```csharp
// Example code
Order stopOrder;
stopOrder.StopPriceChanged = stopOrder.StopPrice - 4 * stopOrder.Instrument.MasterInstrument.TickSize;

private void OnExecutionUpdate(object sender, ExecutionEventArgs e)
{
    // Change the stop order if an execution results in a long position
    if(e.MarketPosition == MarketPosition.Long)
        myAccount.Change(new[] { stopOrder });
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./change.md)
*   [Syntax](./change.md)
*   [Parameters](./change.md)
*   [Examples](./change.md)