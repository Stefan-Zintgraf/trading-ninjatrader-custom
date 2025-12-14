**Path**: [Rendering](./rendering.md) > [MinValue](./minvalue.md)

# MinValue

# MinValue

## [Definition](./minvalue.md)

The minimum value used for the automatic scaling of the y axis. This property will only be used when the chart object is set to **IsAutoScale**.

## [Property Value](./minvalue.md)

A **double** value.

## [Syntax](./minvalue.md)

`MinValue`

## [Examples](./minvalue.md)

```csharp

public override void OnCalculateMinMax()
{
   if (DrawingState != DrawingState.Building)
   {
     //set the minimum value to the chart anchors price
     MinValue = Anchor.Price;
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./minvalue.md)
*   [Property Value](./minvalue.md)
*   [Syntax](./minvalue.md)
*   [Examples](./minvalue.md)