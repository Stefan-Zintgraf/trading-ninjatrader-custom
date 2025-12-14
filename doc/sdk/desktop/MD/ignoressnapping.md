**Path**: [ChartAnchor](./chartanchor.md) > [IgnoresSnapping](./ignoressnapping.md)

# IgnoresSnapping

# IgnoresSnapping

## [Definition](./ignoressnapping.md)

Determines if the drawing tool chart anchor's will use the chart's Snap Mode mouse coordinates.

## [Property Value](./ignoressnapping.md)

A bool value which when true the drawing tool ignores snapping; otherwise false. Default is set to false.

## [Syntax](./ignoressnapping.md)

`IgnoresSnapping`

## [Examples](./ignoressnapping.md)

```csharp

protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
          IgnoresSnapping = true; // Set this to true to receive non-snapped mouse coordinates
     }
     else if (State == State.Configure)
     {

     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./ignoressnapping.md)
*   [Property Value](./ignoressnapping.md)
*   [Syntax](./ignoressnapping.md)
*   [Examples](./ignoressnapping.md)