**Path**: [Draw.TimeCycles()](./draw_timecycles.md) > [TimeCycles](./timecycles.md)

# TimeCycles

# TimeCycles

## [Definition](./timecycles.md)

Represents an interface that exposes information regarding a TimeCycles **IDrawingTool**.

## [Methods and Properties](./timecycles.md)

Parameter

Description

Anchor

An **IDrawingTool's ChartAnchor** representing the point of the drawing object

OutlineStroke

A Stroke used for the outline of the region

AreaBrush

A **Brush** object representing the fill color of the draw object

## [Examples](./timecycles.md)

```csharp
// Instantiate a Time Cycles object
TimeCycles myTimeCycles = (this, "tag1", 0, 10, Brushes.CornflowerBlue, Brushes.CornflowerBlue, 40);

// Change the object's OutlineBrush
myTimeCycles.OutlineStroke = new Stroke(Brushes.Red);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./timecycles.md)
*   [Methods and Properties](./timecycles.md)
*   [Examples](./timecycles.md)