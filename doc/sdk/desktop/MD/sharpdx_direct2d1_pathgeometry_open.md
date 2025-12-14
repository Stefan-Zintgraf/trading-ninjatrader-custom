**Path**: [SharpDX.Direct2D1.PathGeometry](./sharpdx_direct2d1_pathgeometry.md) > [SharpDX.Direct2D1.PathGeometry.Open()](./sharpdx_direct2d1_pathgeometry_open.md)

# SharpDX.Direct2D1.PathGeometry.Open()

# SharpDX.Direct2D1.PathGeometry.Open()

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Disclaimer: The **SharpDX SDK Reference** section was compiled from the official **SharpDX Documentation** and was NOT authored by NinjaTrader. The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK. This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly. Please refer to the official SharpDX Documentation for additional members not covered in this reference. For more seasoned graphic developers, the original MSDN **Direct2D1** and **DirectWrite** unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page.

## [Definition](./sharpdx_direct2d1_pathgeometry_open.md)

Retrieves the geometry sink that is used to populate the path geometry with figures and segments.

(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd371522.aspx))

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Notes:

1.  Because path geometries are immutable and can only be populated once, it is an error to call **Open()** on a path geometry more than once.
2.  Note that the fill mode defaults to Alternate. To set the fill mode, call [SetFillMode()](./sharpdx_direct2d1_geometrysink_setfillmode.md) before the first call to [BeginFigure()](./sharpdx_direct2d1_geometrysink_addlines.md). Failure to do so will put the geometry sink in an error state.

## [Method Return Value](./sharpdx_direct2d1_pathgeometry_open.md)

A [SharpDX.Direct2D1.GeometrySink](./sharpdx_direct2d1_geometrysink.md) which contains the address of a reference to the geometry sink that is used to populate the path geometry with figures and segments.

## [Syntax](./sharpdx_direct2d1_pathgeometry_open.md)

`<pathgeometry>.Open()`

## [Parameters](./sharpdx_direct2d1_pathgeometry_open.md)

This method does not accept any parameters.

#### ON THIS PAGE

*   [Definition](./sharpdx_direct2d1_pathgeometry_open.md)
*   [Method Return Value](./sharpdx_direct2d1_pathgeometry_open.md)
*   [Syntax](./sharpdx_direct2d1_pathgeometry_open.md)
*   [Parameters](./sharpdx_direct2d1_pathgeometry_open.md)