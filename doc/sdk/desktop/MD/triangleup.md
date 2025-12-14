**Path**: [Draw.TriangleUp()](./draw_triangleup.md) > [TriangleUp](./triangleup.md)

# TriangleUp

# TriangleUp

## [Definition](./triangleup.md)

Represents an interface that exposes information regarding a Triangle Up [IDrawingTool](./idrawingtool.md).

## [Methods and Properties](./triangleup.md)

Parameter

Description

Anchor

An [IDrawingTool's ChartAnchor](./chartanchor.md) representing the point of the drawing object

AreaBrush

A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object

OutlineBrush

A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the outline color of the draw object

## [Examples](./triangleup.md)

```csharp
// Instantiate a TriangleUp object  
TriangleUp myTri = Draw.TriangleUp(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);              
   
// Change the object's AreaBrush  
myTri.AreaBrush = Brushes.Beige;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./triangleup.md)
*   [Methods and Properties](./triangleup.md)
*   [Examples](./triangleup.md)