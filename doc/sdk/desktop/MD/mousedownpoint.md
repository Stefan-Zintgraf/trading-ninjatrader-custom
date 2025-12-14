**Path**: [ChartControl](./chartcontrol.md) > [MouseDownPoint](./mousedownpoint.md)

# MouseDownPoint

# MouseDownPoint

## [Definition](./mousedownpoint.md)

Indicates the WPF x\- and y\-coordinates of the mouse cursor at the most recent **OnMouseDown()** event.

## [Property Value](./mousedownpoint.md)

A [Point](https://msdn.microsoft.com/en-us/library/system.drawing.point(v=vs.110).aspx) object containing x\- and y\-coordinates of the mouse cursor when the left mouse button is clicked or held.

## [Syntax](./mousedownpoint.md)

`<chartcontrol>.MouseDownPoint`

## [Examples](./mousedownpoint.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   Point cursorPoint = chartControl.MouseDownPoint;
 
   // Print the x- and y-coordinates of the mouse cursor when clicked
   Print(String.Format("Mouse clicked at coordinates {0},{1}", cursorPoint.X, cursorPoint.Y));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./mousedownpoint.md)
*   [Property Value](./mousedownpoint.md)
*   [Syntax](./mousedownpoint.md)
*   [Examples](./mousedownpoint.md)