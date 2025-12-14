**Path**: [SharpDX.Direct2D1.GradientStopCollection](./sharpdx_direct2d1_gradientstopcollection.md) > [SharpDX.Direct2D1.GradientStopCollection.ColorInterpolationGamma](./sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md)

# SharpDX.Direct2D1.GradientStopCollection.ColorInterpolationGamma

# SharpDX.Direct2D1.GradientStopCollection.ColorInterpolationGamma

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Disclaimer: The **SharpDX SDK Reference** section was compiled from the official **SharpDX Documentation** and was NOT authored by NinjaTrader. The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK. This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly. Please refer to the official SharpDX Documentation for additional members not covered in this reference. For more seasoned graphic developers, the original MSDN **Direct2D1** and **DirectWrite** unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page.

## [Definition](./sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md)

Indicates the gamma space in which the gradient stops are interpolated.

(See also **unmanaged API documentation**)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Interpolating in a linear gamma space (**Gamma.Linear**) can avoid changes in perceived brightness caused by the effect of gamma correction in spaces where the gamma is not 1.0, such as the default sRGB color space, where the gamma is 2.2.

## [Property Value](./sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md)

A **SharpDX.Direct2D1.Gamma** enum value specifies which gamma is used for interpolation.

Possible values include:

StandardRgb

Interpolation is performed in the standard RGB (sRGB) gamma.

Linear

Interpolation is performed in the linear\-gamma color space.

(see also **unmanaged API documentation**)

## [Syntax](./sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md)

`<gradientstopcollection>.ColorInterpolationGamma`

#### ON THIS PAGE

*   [Definition](./sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md)
*   [Property Value](./sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md)
*   [Syntax](./sharpdx_direct2d1_gradientstopcollection_colorinterpolationgamma.md)