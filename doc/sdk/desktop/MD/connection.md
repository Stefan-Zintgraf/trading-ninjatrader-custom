**Path**: [Account Class](./account_class.md) > [Connection](./connection.md)

# Connection

# Connection

## [Definition](./connection.md)

Indicates the data connection used for the specified account.

## [Property Value](./connection.md)

An instance of the **Connection** class containing information about the connection used for a specified account.

## [Syntax](./connection.md)

`<account>.Connection`

## [Examples](./connection.md)

```csharp
private Account myAccount;

protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        myAccount = Account.All.FirstOrDefault(a => a.Name == "Sim101");
    }
}

private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e)
{
    Print(String.Format("{0} connection updated", myAccount.Connection.Options.Name));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./connection.md)
*   [Property Value](./connection.md)
*   [Syntax](./connection.md)
*   [Examples](./connection.md)