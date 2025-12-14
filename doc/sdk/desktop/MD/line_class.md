**Path**: [AddLine()](./addline.md) > [Line Class](./line_class.md)

# Line Class

# Line Class

## [Definition](./line_class.md)

Objects derived from the **Line** class are used to characterize how an oscillator line is visually displayed (plotted) on a chart.

## [Properties](./line_class.md)

Brush

The System.Windows.Media.Brush used to construct the line ([reference](https://msdn.microsoft.com/en-us/library/system.windows.media.brushes%28v=vs.110%29.aspx))

BrushDX

A [SharpDX.Direct2D1.Brush](./sharpdx_direct2d1_brush.md) used to actually render the line.

DashStyleDX

A [SharpDX.Direct2D1.DashStyle](./sharpdx_direct2d1_strokestyle_dashstyle.md) used to render the stroke style.

**Note**: To avoid and resolve access violation exceptions, please see Warning and examples remarked below

DashStyleHelper

A dashstyle used to construct the stroke. Possible values are:

*   **DashStyleHelper.Dash**
*   **DashStyleHelper.DashDot**
*   **DashStyleHelper.DashDotDot**
*   **DashStyleHelper.Dot**
*   **DashStyleHelper.Solid**

Name

A **string** representing the name of the line

RenderTarget

The [RenderTarget](./rendertarget.md) drawing context used for the line.

StrokeStyle

A [SharpDX.Direct2D1.StrokeStyle](./sharpdx_direct2d1_strokestyle.md)

Value

A **double** representing the value of the line

Width

A **float** representing the width in pixels

## [Examples](./line_class.md)

See the [AddLine()](./addline.md) method for examples.

#### ON THIS PAGE

*   [Definition](./line_class.md)
*   [Properties](./line_class.md)
*   [Examples](./line_class.md)