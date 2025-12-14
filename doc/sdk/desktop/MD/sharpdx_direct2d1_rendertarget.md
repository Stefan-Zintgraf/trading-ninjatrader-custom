**Path**: [SharpDX.Direct2D1.RenderTarget](./sharpdx_direct2d1_rendertarget.md)

# SharpDX.Direct2D1.RenderTarget

# SharpDX.Direct2D1.RenderTarget

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Disclaimer: The **SharpDX SDK Reference** section was compiled from the official **SharpDX Documentation** and was NOT authored by NinjaTrader. The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK. This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly. Please refer to the official SharpDX Documentation for additional members not covered in this reference. For more seasoned graphic developers, the original MSDN **Direct2D1** and **DirectWrite** unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page.

## [Definition](./sharpdx_direct2d1_rendertarget.md)

Represents an object that can receive drawing commands.

(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd371766.aspx))

## [Syntax](./sharpdx_direct2d1_rendertarget.md)

`class RenderTarget`

## [Tips](./sharpdx_direct2d1_rendertarget.md)

1.  For NinjaScript Development purposes, [DrawingTools](./drawingtool.md), [ChartStyles](./chartstyletype.md), [Indicators](./system_indicator_methods.md), and [Strategies](./strategy.md) implement the Chart's [RenderTarget](./rendertarget.md) ready to be used in the OnRender() method.
2.  General information on Direct2D Render Targets can be found on the [MSDN Direct2D Render Targets Overview](https://msdn.microsoft.com/en-us/library/dd756757(v=vs.85).aspx).

## [Methods and Properties](./sharpdx_direct2d1_rendertarget.md)

Method/Property

Description

[AntialiasMode](./sharpdx_direct2d1_rendertarget_antialiasmode.md)

Retrieves or sets the current antialiasing mode for nontext drawing operations.

[DrawEllipse()](./sharpdx_direct2d1_rendertarget_drawellipse.md)

Draws the outline of the specified ellipse using the specified stroke style.

[DrawGeometry()](./sharpdx_direct2d1_rendertarget_drawgeometry.md)

Draws the outline of the specified geometry.

[DrawLine()](./sharpdx_direct2d1_rendertarget_drawline.md)

Draws a line between the specified points.

[DrawRectangle()](./sharpdx_direct2d1_rendertarget_drawrectangle.md)

Draws the outline of a rectangle that has the specified dimensions.

[DrawText()](./sharpdx_direct2d1_rendertarget_drawtext.md)

Draws the specified text using the format information provided by an **SharpDX.DirectWrite.TextFormat** object.

[DrawTextLayout()](./sharpdx_direct2d1_rendertarget_drawtextlayout.md)

Draws the formatted text described by the specified **SharpDX.DirectWrite.TextLayout** object.

[FillEllipse()](./sharpdx_direct2d1_rendertarget_fillellipse.md)

Paints the interior of the specified ellipse.

[FillGeometry()](./sharpdx_direct2d1_rendertarget_fillgeometry.md)

Paints the interior of the specified geometry.

[FillRectangle()](./sharpdx_direct2d1_rendertarget_fillrectangle.md)

Paints the interior of the specified rectangle.

[IsDisposed](./sharpdx_disposebase_isdisposed.md)

Gets a value indicating whether this instance is disposed. (Inherited from **SharpDX.DisposeBase**.)

[Transform](./sharpdx_direct2d1_rendertarget_transform.md)

Gets or sets the current transform of the render target.

#### ON THIS PAGE

*   [Definition](./sharpdx_direct2d1_rendertarget.md)
*   [Syntax](./sharpdx_direct2d1_rendertarget.md)
*   [Tips](./sharpdx_direct2d1_rendertarget.md)
*   [Methods and Properties](./sharpdx_direct2d1_rendertarget.md)