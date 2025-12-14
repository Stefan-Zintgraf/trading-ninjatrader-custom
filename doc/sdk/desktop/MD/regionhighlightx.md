**Path**: [Draw.RegionHighlightX()](./draw_regionhighlightx.md) > [RegionHighlightX](./regionhighlightx.md)

# RegionHighlightX

# RegionHighlightX

## [Definition](./regionhighlightx.md)

Represents an interface that exposes information regarding a Region Highlight X **IDrawingTool**.

## [Methods and Properties](./regionhighlightx.md)

Parameter

Description

StartAnchor

An **IDrawingTool's ChartAnchor** representing the starting point of the drawing object

EndAnchor

An **IDrawingTool's ChartAnchor** representing the end point of the drawing object

AreaBrush

A **Brush** class representing the fill color of the draw object

AreaOpacity

An **int** value representing the opacity of the area color

OutlineStroke

The **Stroke** object used to draw the object's outline

## [Examples](./regionhighlightx.md)

```csharp
// Instantiate a RegionHighlightX object
RegionHighlightX myReg = Draw.RegionHighlightX(this, "tag1", 10, 0, Brushes.Blue);
 
// Change the object's opacity
myReg.AreaOpacity = 25;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./regionhighlightx.md)
*   [Methods and Properties](./regionhighlightx.md)
*   [Examples](./regionhighlightx.md)