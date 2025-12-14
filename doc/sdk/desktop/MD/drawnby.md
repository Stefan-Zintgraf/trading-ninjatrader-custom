**Path**: [ChartAnchor](./chartanchor.md) > [DrawnBy](./drawnby.md)

# DrawnBy

# DrawnBy

## [Definition](./drawnby.md)

Represents the **NinjaScript** object which created the drawing object.

## [Property Value](./drawnby.md)

The **NinjaScript** object which created the drawing tool; this value will be null if drawn by a user.

## [Syntax](./drawnby.md)

`DrawnBy`

## [Examples](./drawnby.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{       
    // if the drawing tool was not created by a user, 
    // print the name of the object that it was created       
    if(!IsUserDrawn)
        Print(DrawnBy.Name);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./drawnby.md)
*   [Property Value](./drawnby.md)
*   [Syntax](./drawnby.md)
*   [Examples](./drawnby.md)