**Path**: [Draw.VerticalLine()](./draw_verticalline.md) > [VerticalLine](./verticalline.md)

# VerticalLine

# VerticalLine

## [Definition](./verticalline.md)

Represents an interface that exposes information regarding a Vertical Line [IDrawingTool](./idrawingtool.md).

## [Methods and Properties](./verticalline.md)

Parameter

Description

StartAnchor

An [IDrawingTool's ChartAnchor](./chartanchor.md) representing the starting point of the drawing object

EndAnchor

An [IDrawingTool's ChartAnchor](./chartanchor.md) representing the end point of the drawing object

Stroke

A [Stroke](./stroke_class.md) object used to draw the object

## [Examples](./verticalline.md)

```csharp
// Instantiate a VerticalLine object  
VerticalLine myLine = Draw.VerticalLine(this, "tag1", 10, Brushes.Black);  
   
// Change the object's Stroke  
myLine.Stroke = new Stroke(Brushes.BlanchedAlmond, DashStyleHelper.Dot, 5);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./verticalline.md)
*   [Methods and Properties](./verticalline.md)
*   [Examples](./verticalline.md)