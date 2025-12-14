**Path**: [Drawing](./drawing.md) > [AllowRemovalOfDrawObjects](./allowremovalofdrawobjects.md)

# AllowRemovalOfDrawObjects

# AllowRemovalOfDrawObjects

## [Definition](./allowremovalofdrawobjects.md)

Determines if programmatically drawn **DrawObjects** are allowed to remove manually from the chart

## [Property Value](./allowremovalofdrawobjects.md)

When set to true, the draw objects from the indicator or strategy can be deleted from the chart manually by a user. If false, draw objects from the indicator or strategy can only be removed from the chart if the script removes the drawing object, or the script is terminates. Default set to false.

## [Syntax](./allowremovalofdrawobjects.md)

`AllowRemovalOfDrawObjects`

## [Examples](./allowremovalofdrawobjects.md)

```csharp
protected override void OnStateChange()
{
     Add(new Plot(Brushes.Orange, "SMA"));
     AllowRemovalOfDrawObjects = true; // Draw objects can be removed separately from the script
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./allowremovalofdrawobjects.md)
*   [Property Value](./allowremovalofdrawobjects.md)
*   [Syntax](./allowremovalofdrawobjects.md)
*   [Examples](./allowremovalofdrawobjects.md)