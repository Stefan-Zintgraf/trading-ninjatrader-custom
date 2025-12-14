**Path**: [PositionAccount](./positionaccount.md) > [Quantity](./positionaccount_quantity.md)

# Quantity

# Quantity

## [Definition](./positionaccount_quantity.md)

Gets the current account's position size.

## [Property Value](./positionaccount_quantity.md)

An **int** value representing the account's position size.

## [Syntax](./positionaccount_quantity.md)

`PositionAccount.Quantity`

## [Examples](./positionaccount_quantity.md)

```csharp
protected override void OnBarUpdate()
{ 
    // Prints out the current market position
    Print(PositionAccount.MarketPosition.ToString() + " " + PositionAccount.Quantity.ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./positionaccount_quantity.md)
*   [Property Value](./positionaccount_quantity.md)
*   [Syntax](./positionaccount_quantity.md)
*   [Examples](./positionaccount_quantity.md)