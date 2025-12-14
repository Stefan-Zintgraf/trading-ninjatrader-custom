**Path**: [ChartingExtensions](./chartingextensions.md) > [ConvertFromHorizontalPixels](./convertfromhorizontalpixels.md)

# ConvertFromHorizontalPixels

# ConvertFromHorizontalPixels

## [Definition](./convertfromhorizontalpixels.md)

Converts an x\-axis pixel coordinate from device pixels to application pixels.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](./working_with_pixel_coordinates.md).

## [Method Return Value](./convertfromhorizontalpixels.md)

A double representing an x\-coordinate value in terms of application pixels.

## [Syntax](./convertfromhorizontalpixels.md)

`ChartingExtensions.ConvertFromHorizontalPixels(this int x, PresentationSource target)`

`int.ConvertFromHorizontalPixels(PresentationSource target)`

## [Parameters](./convertfromhorizontalpixels.md)

Parameter

Description

**x**

The horizontal int coordinates in device pixels to convert.

**target**

The [PresentationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion. Note: For Charts, see [ChartControl.PresentationSource](./presentationsource.md).

## [Examples](./convertfromhorizontalpixels.md)

```csharp
int applicationPixelX;

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Obtain the application-pixel coordinate corresponding to a device-pixel X value of 500
    applicationPixelX = ChartingExtensions.ConvertFromHorizontalPixels(500, ChartControl.PresentationSource);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./convertfromhorizontalpixels.md)
*   [Method Return Value](./convertfromhorizontalpixels.md)
*   [Syntax](./convertfromhorizontalpixels.md)
*   [Parameters](./convertfromhorizontalpixels.md)
*   [Examples](./convertfromhorizontalpixels.md)