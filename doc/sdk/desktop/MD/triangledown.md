**Path**: [Draw.TriangleDown()](./draw_triangledown.md) > [TriangleDown](./triangledown.md)

# TriangleDown

# TriangleDown

## [Definition](./triangledown.md)

Represents an interface that exposes information regarding a Triangle Down [IDrawingTool](./idrawingtool.md).

## [Methods and Properties](./triangledown.md)

Parameter

Description

Anchor

An [IDrawingTool's ChartAnchor](./chartanchor.md) representing the point of the drawing object

AreaBrush

A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object

OutlineBrush

A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the outline color of the draw object

## [Example](./triangledown.md)

```csharp
// Instantiate a TriangleDown object  
TriangleDown myTri = Draw.TriangleDown(this, "tag1", true, 0, Low[0] - TickSize, Brushes.Red);              
   
// Change the object's AreaBrush  
myTri.AreaBrush = Brushes.Beige;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./triangledown.md)
*   [Methods and Properties](./triangledown.md)
*   [Example](./triangledown.md)