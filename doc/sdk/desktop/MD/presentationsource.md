**Path**: [ChartControl](./chartcontrol.md) > [PresentationSource](./presentationsource.md)

# PresentationSource

# PresentationSource

## [Definition](./presentationsource.md)

Provides a reference to the base window in which the chart is rendered. **PresentationSource** can be used when converting application pixels to/from device pixels via the helper methods in the [ChartingExtensions](./chartingextensions.md) class.

## [Property Value](./presentationsource.md)

A **PresentationSource** object representing the base window in which the chart is rendered.

## [Syntax](./presentationsource.md)

`ChartControl.PresentationSource`

## [Examples](./presentationsource.md)

```csharp
int devicePixelX;
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   // Obtain the device-pixel coordinate corresponding to an application-pixel X value of 500
   devicePixelX = ChartingExtensions.ConvertToHorizontalPixels(500, ChartControl.PresentationSource);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./presentationsource.md)
*   [Property Value](./presentationsource.md)
*   [Syntax](./presentationsource.md)
*   [Examples](./presentationsource.md)