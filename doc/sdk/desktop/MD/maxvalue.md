**Path**: [Rendering](./rendering.md) > [MaxValue](./maxvalue.md)

# MaxValue

# MaxValue

## [Definition](./maxvalue.md)

The maximum value used for the automatic scaling of the y axis. This property will only be used when the chart object is set to \[isautoscale\].

## [Property Value](./maxvalue.md)

A **double** value.

## [Syntax](./maxvalue.md)

`MaxValue`

## [Examples](./maxvalue.md)

```csharp

public override void OnCalculateMinMax()
{
    if (DrawingState != DrawingState.Building)
    {
        //set the maximum value to the chart anchors price
        MaxValue = Anchor.Price;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./maxvalue.md)
*   [Property Value](./maxvalue.md)
*   [Syntax](./maxvalue.md)
*   [Examples](./maxvalue.md)