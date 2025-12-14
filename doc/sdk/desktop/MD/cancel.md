**Path**: [Account Class](./account_class.md) > [Cancel()](./cancel.md)

# Cancel()

# Cancel()

## [Definition](./cancel.md)

Cancels specified **Order** object(s).

## [Syntax](./cancel.md)

`Cancel(IEnumerable<`order`> orders)`

## [Parameters](./cancel.md)

orders

Order(s) to cancel

## [Examples](./cancel.md)

```csharp
private Account myAccount;
Order stopOrder = null;

protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Initialize myAccount
    }
}

private void OnExecutionUpdate(object sender, ExecutionEventArgs e)
{
    // Cancel the stop order if an execution results in a long position
    if(e.MarketPosition == MarketPosition.Long)
        myAccount.Cancel(new[] { stopOrder });
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./cancel.md)
*   [Syntax](./cancel.md)
*   [Parameters](./cancel.md)
*   [Examples](./cancel.md)