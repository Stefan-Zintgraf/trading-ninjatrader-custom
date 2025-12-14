**Path**: [Account Class](./account_class.md) > [Denomination](./denomination.md)

# Denomination

# Denomination

## [Definition](./denomination.md)

Indicates the currency set on an account

## [Property Value](./denomination.md)

A Currency object containing information about the currency denomination specified in the referenced account

## [Syntax](./denomination.md)

`account>.Connection`

## [Examples](./denomination.md)

```csharp
private Account myAccount;

protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Initialize myAccount here

        // Print myAccount's currency denomination
        NinjaTrader.Code.Output.Process("myAccount currency is set to " + myAccount.Denomination, PrintTo.OutputTab1);
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./denomination.md)
*   [Property Value](./denomination.md)
*   [Syntax](./denomination.md)
*   [Examples](./denomination.md)