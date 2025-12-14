**Path**: [Rendering](./rendering.md) > [IsInHitTest](./isinhittest.md)

# IsInHitTest

# IsInHitTest

## [Definition](./isinhittest.md)

Indicates a user is currently clicking in the chart panel in which the calling script resides.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

In addition to the example below, **IsInHitTest** can also be tested directly on chart objects (for example, **myHorizontalLine.IsInHitTest**). In this case, the **IsInHitTest** property of a specific object will refer to the panel in which the calling script resides, even if the calling script resides in a different panel than the object itself.

## [Property Value](./isinhittest.md)

This property returns true to indicate that the chart panel in which the script resides is being clicked on; otherwise, false. Default set to false.

## [Syntax](./isinhittest.md)

`IsInHitTest`

## [Examples](./isinhittest.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
   if(IsInHitTest)
   {
       Print("user clicked on object");

       // do something
   }
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isinhittest.md)
*   [Property Value](./isinhittest.md)
*   [Syntax](./isinhittest.md)
*   [Examples](./isinhittest.md)