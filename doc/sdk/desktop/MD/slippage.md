**Path**: [PositionAccount](./positionaccount.md) > [Slippage](./slippage.md)

# Slippage

# Slippage

## [Definition](./slippage.md)

Sets the amount of slippage in ticks per execution used in performance calculations during backtests.

## [Property Value](./slippage.md)

An **int** value representing the number ticks. Default value is set to 0.

## [Syntax](./slippage.md)

`Slippage`

## [Examples](./slippage.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         Slippage = 2; 
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./slippage.md)
*   [Property Value](./slippage.md)
*   [Syntax](./slippage.md)
*   [Examples](./slippage.md)