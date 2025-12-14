**Path**: [ChartingExtensions](./chartingextensions.md) > [ConvertFromVerticalPixels](./convertfromverticalpixels.md)

# ConvertFromVerticalPixels

# ConvertFromVerticalPixels

## [Definition](./convertfromverticalpixels.md)

Converts a y\-axis pixel coordinate from device pixels to application pixels.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](./working_with_pixel_coordinates.md).

## [Method Return Value](./convertfromverticalpixels.md)

A double representing a y\-coordinate value in terms of application pixels.

## [Syntax](./convertfromverticalpixels.md)

`ChartingExtensions.ConvertFromVerticalPixels(this int x, PresentationSource target)`

`<int>.ConvertFromVerticalPixels(PresentationSource target)`

## [Parameters](./convertfromverticalpixels.md)

x

target

The vertical int coordinates in device pixels to convert

The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion. Note: For Charts, see [ChartControl.PresentationSource](./presentationsource.md).

## [Examples](./convertfromverticalpixels.md)

```csharp
int applicationPixelY;

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Obtain the application-pixel coordinate corresponding to a device-pixel Y value of 500
    applicationPixelY = ChartingExtensions.ConvertFromVerticalPixels(500, ChartControl.PresentationSource);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./convertfromverticalpixels.md)
*   [Method Return Value](./convertfromverticalpixels.md)
*   [Syntax](./convertfromverticalpixels.md)
*   [Parameters](./convertfromverticalpixels.md)
*   [Examples](./convertfromverticalpixels.md)