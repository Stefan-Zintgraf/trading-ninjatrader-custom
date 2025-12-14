**Path**: [ChartingExtensions](./chartingextensions.md) > [ConvertToHorizontalPixels](./converttohorizontalpixels.md)

# ConvertToHorizontalPixels

# ConvertToHorizontalPixels

## [Definition](./converttohorizontalpixels.md)

Converts an x\-axis pixel coordinate from application pixels to device pixels.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](./working_with_pixel_coordinates.md).

## [Method Return Value](./converttohorizontalpixels.md)

An int representing an x\-coordinate value in terms of device pixels.

## [Syntax](./converttohorizontalpixels.md)

`ChartingExtensions.ConvertToHorizontalPixels(this double x, PresentationSource target)`

`<double>.ConvertToHorizontalPixels(PresentationSource target)`

## [Parameters](./converttohorizontalpixels.md)

**x**

The horizontal double coordinates in application pixels to convert

**target**

The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion.  
Note: For Charts, see [ChartControl.PresentationSource](./presentationsource.md).

## [Examples](./converttohorizontalpixels.md)

```csharp
int devicePixelX;

protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Obtain the device-pixel coordinate corresponding to an application pixel X-value of 500
    devicePixelX = ChartingExtensions.ConvertToHorizontalPixels(500, ChartControl.PresentationSource);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./converttohorizontalpixels.md)
*   [Method Return Value](./converttohorizontalpixels.md)
*   [Syntax](./converttohorizontalpixels.md)
*   [Parameters](./converttohorizontalpixels.md)
*   [Examples](./converttohorizontalpixels.md)