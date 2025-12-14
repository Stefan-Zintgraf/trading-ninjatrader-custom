**Path**: [Draw.Triangle()](./draw_triangle.md) > [Triangle](./triangle.md)

# Triangle

# Triangle

## [Definition](./triangle.md)

Represents an interface that exposes information regarding a Triangle [IDrawingTool](./idrawingtool.md).

## [Methods and Properties](./triangle.md)

Parameter

Description

StartAnchor

An [IDrawingTool's ChartAnchor](./chartanchor.md) representing the starting point of the drawing object

MiddleAnchor

An [IDrawingTool's ChartAnchor](./chartanchor.md) representing the middle point of the drawing object

EndAnchor

An [IDrawingTool's ChartAnchor](./chartanchor.md) representing the end point of the drawing object

AreaBrush

A [Brush](http://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) class representing the fill color of the draw object

AreaOpacity

An int value representing the opacity of the area color

OutlineStroke

The [Stroke](./stroke_class.md) object used to draw the object's outline

## [Example](./triangle.md)

```csharp
// Instantiate a Triangle object  
Triangle myTri = Draw.Triangle(this, "tag1", 4, Low[4], 3, High[3], 1, Low[1], Brushes.Blue);              
   
// Change the object's AreaOpacity  
myTri.AreaOpacity = 100;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./triangle.md)
*   [Methods and Properties](./triangle.md)
*   [Example](./triangle.md)