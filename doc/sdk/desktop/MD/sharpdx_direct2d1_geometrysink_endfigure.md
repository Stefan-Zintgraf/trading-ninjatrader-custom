**Path**: [SharpDX.Direct2D1.GeometrySink](./sharpdx_direct2d1_geometrysink.md) > [SharpDX.Direct2D1.GeometrySink.EndFigure()](./sharpdx_direct2d1_geometrysink_endfigure.md)

# SharpDX.Direct2D1.GeometrySink.EndFigure()

# SharpDX.Direct2D1.GeometrySink.EndFigure()

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Disclaimer: The **SharpDX SDK Reference** section was compiled from the official **SharpDX Documentation** and was NOT authored by NinjaTrader. The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK. This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly. Please refer to the official SharpDX Documentation for additional members not covered in this reference. For more seasoned graphic developers, the original MSDN **Direct2D1** and **DirectWrite** unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page.

## [Definition](./sharpdx_direct2d1_geometrysink_endfigure.md)

Ends the current figure; optionally, closes it.

(See also [unmanaged API documentation](https://msdn.microsoft.com/en-us/library/dd316934.aspx))

## [Method Return Value](./sharpdx_direct2d1_geometrysink_endfigure.md)

This method does not return a value.

## [Syntax](./sharpdx_direct2d1_geometrysink_endfigure.md)

`<geometrysink>.EndFigure(FigureEnd figureEnd)`

## [Parameters](./sharpdx_direct2d1_geometrysink_endfigure.md)

figureEnd

A **SharpDX.Direct2D1.FigureEnd** value that indicates whether the current figure is closed. If the figure is closed, a line is drawn between the current point and the start point specified by **BeginFigure()**.

#### ON THIS PAGE

*   [Definition](./sharpdx_direct2d1_geometrysink_endfigure.md)
*   [Method Return Value](./sharpdx_direct2d1_geometrysink_endfigure.md)
*   [Syntax](./sharpdx_direct2d1_geometrysink_endfigure.md)
*   [Parameters](./sharpdx_direct2d1_geometrysink_endfigure.md)