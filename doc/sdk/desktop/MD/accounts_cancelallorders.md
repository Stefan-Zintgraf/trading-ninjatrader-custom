**Path**: [Account Class](./account_class.md) > [CancelAllOrders()](./accounts_cancelallorders.md)

# CancelAllOrders()

# CancelAllOrders()

## [Definition](./accounts_cancelallorders.md)

Cancels all [Order](./order.md) of an instrument.

## [Syntax](./accounts_cancelallorders.md)

`CancelAllOrders(Instrument instrument)`

## [Parameters](./accounts_cancelallorders.md)

instrument

Instrument of the orders to be cancelled

## [Example](./accounts_cancelallorders.md)

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

*   [Definition](./accounts_cancelallorders.md)
*   [Syntax](./accounts_cancelallorders.md)
*   [Parameters](./accounts_cancelallorders.md)
*   [Example](./accounts_cancelallorders.md)