**Path**: [Account Class](./account_class.md) > [Strategies](./strategies.md)

# Strategies

# Strategies

## [Definition](./strategies.md)

A collection of **StrategyBase** objects generated for the specified account

## [Property Value](./strategies.md)

An [Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of **StrategyBase** objects

## [Syntax](./strategies.md)

`<account>.Strategies`

## [Examples](./strategies.md)

```csharp
private Account myAccount;

protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Initialize myAccount
    }
}

private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e)
{
    foreach (StrategyBase strategy in myAccount.Strategies)
    {
        Print(String.Format("Account status updated. {0} strategy applied with position {1}", strategy.Name, strategy.Position));
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./strategies.md)
*   [Property Value](./strategies.md)
*   [Syntax](./strategies.md)
*   [Examples](./strategies.md)