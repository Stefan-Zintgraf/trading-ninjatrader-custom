**Path**: [SharpDX.DisposeBase](./sharpdx_disposebase.md) > [SharpDX.DisposeBase.Dispose()](./sharpdx_disposebase_dispose.md)

# SharpDX.DisposeBase.Dispose()

# SharpDX.DisposeBase.Dispose()

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Disclaimer: The **SharpDX SDK Reference** section was compiled from the official **SharpDX Documentation** and was NOT authored by NinjaTrader. The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK. This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly. Please refer to the official SharpDX Documentation for additional members not covered in this reference. For more seasoned graphic developers, the original MSDN **Direct2D1** and **DirectWrite** unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page.

## [Definition](./sharpdx_disposebase_dispose.md)

Performs application\-defined tasks associated with freeing, releasing, or resetting unmanaged resources. (Implements I**Disposable.Dispose()**)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Tip: For NinjaScript development purposes, the following documented SharpDX objects require **Dispose()** after they are used:

*   [Brush](./sharpdx_direct2d1_brush.md)
*   [GeometrySink](./sharpdx_direct2d1_geometrysink.md)
*   [GradientStopCollection](./sharpdx_direct2d1_gradientstopcollection.md)
*   [LinearGradientBrush](./sharpdx_direct2d1_lineargradientbrush.md)
*   [PathGeometry](./sharpdx_direct2d1_pathgeometry.md)
*   [RadialGradientBrush](./sharpdx_direct2d1_radialgradientbrush.md)
*   [SolidColorBrush](./sharpdx_direct2d1_solidcolorbrush.md)
*   [StrokeStyle](./sharpdx_direct2d1_strokestyle.md)
*   [TextFormat](./sharpdx_directwrite_textformat.md)
*   [TextLayout](./sharpdx_directwrite_textlayout.md)

There are other undocumented SharpDX objects which are NOT included in this reference. Please be careful to dispose of any object (SharpDX or otherwise) which implements the I**Disposable** interface \- NinjaTrader is NOT guaranteed to dispose of these objects for you!

## [Method return value](./sharpdx_disposebase_dispose.md)

This method does not return a value.

## [Syntax](./sharpdx_disposebase_dispose.md)

`<disposebaseobject>.Dispose()`

#### ON THIS PAGE

*   [Definition](./sharpdx_disposebase_dispose.md)
*   [Method return value](./sharpdx_disposebase_dispose.md)
*   [Syntax](./sharpdx_disposebase_dispose.md)