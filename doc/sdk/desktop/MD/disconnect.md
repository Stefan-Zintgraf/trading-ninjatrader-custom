**Path**: [Connection](./connection_class.md) > [Disconnect()](./disconnect.md)

# Disconnect()

# Disconnect()

## [Definition](./disconnect.md)

Disconnects from the data connection.

## [Syntax](./disconnect.md)

`<connection>.Disconnect()`

## [Examples](./disconnect.md)

```csharp
private void OnExecutionUpdate(object sender, ExecutionEventArgs e)
{
   // If an execution triggers after 9pm, disconnect from the account's data source
   if (e.Time > new DateTime(now.Year, now.Month, now.Day, 21, 0, 0))
       myAccount.Connection.Disconnect();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./disconnect.md)
*   [Syntax](./disconnect.md)
*   [Examples](./disconnect.md)