**Path**: [Account Class](./account_class.md) > [All](./all.md)

# All

# All

## [Definition](./all.md)

A collection of Account objects

## [Property Value](./all.md)

A Collection of Account objects

## [Syntax](./all.md)

`Accounts.All`

## [Examples](./all.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.DataLoaded)
    {
        foreach (Account sampleAccount in Account.All)
        Print(String.Format("The account {0} has a {1} unit FX lotsize set", sampleAccount.Name, sampleAccount.ForexLotSize));
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./all.md)
*   [Property Value](./all.md)
*   [Syntax](./all.md)
*   [Examples](./all.md)