**Path**: [SharpDX.DisposeBase](./sharpdx_disposebase.md) > [SharpDX.Color4](./sharpdx_color4.md)

# SharpDX.Color4

# SharpDX.Color4

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Disclaimer: The **SharpDX SDK Reference** section was compiled from the official **SharpDX Documentation** and was NOT authored by NinjaTrader. The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK. This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly. Please refer to the official SharpDX Documentation for additional members not covered in this reference. For more seasoned graphic developers, the original MSDN **Direct2D1** and **DirectWrite** unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page.

## [Definition](./sharpdx_color4.md)

Represents a color in the form of rgba.

## [Syntax](./sharpdx_color4.md)

`struct Color4`

## [Constructor](./sharpdx_color4.md)

Constructor

Description

`new Color4()`

Initializes a new instance of the Color4 struct

`new Color4(Color3 color3)`

Initializes a new instance of the Color4 struct using a **SharpDX.Color3**([Color3](./sharpdx_color3.md)) struct

`new Color4(Color3 color3, float alpha)`

Initializes a new instance of the Color4 struct using a **SharpDX.Color3**([Color3](./sharpdx_color3.md)) struct with a float for alpha values

`new Color4(float red, float green, float blue, float alpha)`

Initializes a new instance of the Color4 struct using float values for red, green, blue

## [Properties](./sharpdx_color4.md)

Property

Description

**Black**

The Black color (0, 0, 0, 1)

**White**

The White color (1, 1, 1, 1)

**Red**

The red component of the color

**Green**

The green component of the color

**Blue**

The blue component of the color

**Alpha**

The alpha component of the color

#### ON THIS PAGE

*   [Definition](./sharpdx_color4.md)
*   [Syntax](./sharpdx_color4.md)
*   [Constructor](./sharpdx_color4.md)
*   [Properties](./sharpdx_color4.md)