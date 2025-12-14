**Path**: [AddPlot()](./addplot.md) > [Displacement](./displacement.md)

# Displacement

# Displacement

## [Definition](./displacement.md)

An offset value that shifts the visually displayed value of an indicator.

## [Property Value](./displacement.md)

An **int** value that represents the number of bars ago to offset with.

## [Syntax](./displacement.md)

`Displacement`

## [Examples](./displacement.md)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Displacement = 2; // Plots the indicator value from 2 bars ago on the current bar
        AddPlot(Brushes.Orange, "SMA");
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./displacement.md)
*   [Property Value](./displacement.md)
*   [Syntax](./displacement.md)
*   [Examples](./displacement.md)