**Path**: [ChartingExtensions](./chartingextensions.md) > [ConvertToVerticalPixels](./converttoverticalpixels.md)

# ConvertToVerticalPixels

# ConvertToVerticalPixels

## [Definition](./converttoverticalpixels.md)

Converts a y\-axis pixel coordinate from application pixels to device pixels.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](./working_with_pixel_coordinates.md).

## [Method Return Value](./converttoverticalpixels.md)

An int representing a y\-coordinate value in terms of device pixels.

## [Syntax](./converttoverticalpixels.md)

`ChartingExtensions.ConvertToVerticalPixels(this double x, PresentationSource target)`

`double.ConvertToVerticalPixels(PresentationSource target)`

## [Parameters](./converttoverticalpixels.md)

x

target

The vertical double coordinates in application pixels to convert

The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion. Note: For Charts, see [ChartControl.PresentationSource](./presentationsource.md).

## [Examples](./converttoverticalpixels.md)

```csharp
int devicePixelY;

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Obtain the device-pixel coordinate corresponding to an application-pixel Y value of 500
    devicePixelY = ChartingExtensions.ConvertToVerticalPixels(500, ChartControl.PresentationSource);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./converttoverticalpixels.md)
*   [Method Return Value](./converttoverticalpixels.md)
*   [Syntax](./converttoverticalpixels.md)
*   [Parameters](./converttoverticalpixels.md)
*   [Examples](./converttoverticalpixels.md)