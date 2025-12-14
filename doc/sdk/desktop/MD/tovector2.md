**Path**: [Rendering](./rendering.md) > [ToVector2()](./tovector2.md)

# ToVector2()

# ToVector2()

## [Definition](./tovector2.md)

Converts a **System.Windows.Point** structure to a **SharpDX.Vector2** when [Using SharpDX for Custom Chart Rendering](./using_sharpdx_for_custom_chart_rendering.md).

## [Method Return Value](./tovector2.md)

A new **SharpDX.Vector2** constructed with the point parameters X and Y values.

## [Syntax](./tovector2.md)

`DxExtensions.ToVector2(this System.Windows.Point point)`

`<point>.ToVector2()`

## [Parameters](./tovector2.md)

point

The [System.Windows.Point](https://msdn.microsoft.com/en-us/library/system.windows.point(v=vs.110).aspx) point to convert

## [Examples](./tovector2.md)

```csharp
// gets the application/user WPF point and converts to a SharpDX Vector 
System.Windows.Point wpfPoint = ChartControl.MouseDownPoint;

SharpDX.Vector2 dxVector2 = wpfPoint.ToVector2();

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./tovector2.md)
*   [Method Return Value](./tovector2.md)
*   [Syntax](./tovector2.md)
*   [Parameters](./tovector2.md)
*   [Examples](./tovector2.md)