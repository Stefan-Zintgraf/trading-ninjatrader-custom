**Path**: [Account Class](./account_class.md) > [Executions](./executions.md)

# Executions

# Executions

## [Definition](./executions.md)

A collection of Execution objects generated for the specified account. These are the current sessions executions and should match executions reported in the Executions tab of the NinjaTrader Account Data window.

## [Property Value](./executions.md)

An **Collection** of Execution objects

## [Syntax](./executions.md)

`<account>.Executions`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

At this time there is not a supported method to retrieve historical executions from the local database.

## [Examples](./executions.md)

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
    foreach (Execution execution in myAccount.Executions)
    {
        Print(String.Format("Execution triggered for Order {0}", execution.Order));
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./executions.md)
*   [Property Value](./executions.md)
*   [Syntax](./executions.md)
*   [Examples](./executions.md)