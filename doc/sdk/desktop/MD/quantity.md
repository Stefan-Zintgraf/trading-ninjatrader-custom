**Path**: [Position](./position.md) > [Quantity](./quantity.md)

# Quantity

# Quantity

## [Definition](./quantity.md)

Gets the strategy's current position size.

## [Property Value](./quantity.md)

An **int** value representing the position size.

## [Syntax](./quantity.md)

`Position.Quantity`

## [Examples](./quantity.md)

```csharp
protected override void OnBarUpdate()
{
     // Prints out the current market position
     Print(Position.MarketPosition.ToString() + " " + Position.Quantity.ToString());
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./quantity.md)
*   [Property Value](./quantity.md)
*   [Syntax](./quantity.md)
*   [Examples](./quantity.md)