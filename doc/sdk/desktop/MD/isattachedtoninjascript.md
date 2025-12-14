**Path**: [ChartAnchor](./chartanchor.md) > [IsAttachedToNinjaScript](./isattachedtoninjascript.md)

# IsAttachedToNinjaScript

# IsAttachedToNinjaScript

## [Definition](./isattachedtoninjascript.md)

Indicates if the drawing tool is currently **attached to** a NinjaScript object (such an indicator or a strategy).

## [Property Value](./isattachedtoninjascript.md)

A bool value which when true if the drawing tool is attached to a NinjaScript object; otherwise false. This property is read\-only.

## [Syntax](./isattachedtoninjascript.md)

`IsAttachedToNinjaScript`

## [Examples](./isattachedtoninjascript.md)

```csharp
public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)
{
    // do not interact if drawn by an indicator or strategy
    if (IsAttachedToNinjaScript)
        return;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isattachedtoninjascript.md)
*   [Property Value](./isattachedtoninjascript.md)
*   [Syntax](./isattachedtoninjascript.md)
*   [Examples](./isattachedtoninjascript.md)