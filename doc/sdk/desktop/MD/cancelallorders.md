**Path**: [Connection](./connection_class.md) > [CancelAllOrders()](./cancelallorders.md)

# CancelAllOrders()

# CancelAllOrders()

## [Definition](./cancelallorders.md)

Cancels all orders for the specified instrument on the connection.

## [Syntax](./cancelallorders.md)

`<connection>.CancelAllOrders(Instrument instrument)`

instrument

An Instrument object used to identify the instrument for which to cancel orders

## [Examples](./cancelallorders.md)

```csharp
private Account myAccount;

protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Initialize myAccount
    }
}

private void OnExecutionUpdate(object sender, ExecutionEventArgs e)
{
    // Cancel all orders if an execution is triggered after 9pm
    if (e.Time > new DateTime(now.Year, now.Month, now.Day, 21, 0, 0))
        myAccount.CancelAllOrders(e.Execution.Instrument);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./cancelallorders.md)
*   [Syntax](./cancelallorders.md)
*   [Examples](./cancelallorders.md)