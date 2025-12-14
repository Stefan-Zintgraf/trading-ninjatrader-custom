**Path**: [ChartScale](./chartscale.md) > [IsAutoScale](./isautoscale.md)

# IsAutoScale

# IsAutoScale

## [Definition](./isautoscale.md)

If true, the object will call **CalculateMinMax()** in order to determine the object's **MinValue** and **MaxValue** value used to scale the Y\-axis of the chart.

## [Property Value](./isautoscale.md)

This property returns true if the object's are included in the y\-scale; otherwise, false. Default set to false for **DrawingTools**, but set to true for **Indicators**.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during State.SetDefaults or State.Configure.

## [Syntax](./isautoscale.md)

`IsAutoScale`

## [Examples](./isautoscale.md)

```csharp
protected override void OnStateChange()
{
   if (State == State.SetDefaults)
   {         
     Name                 = "Example Indicator";         
     // set this to true to call CalculateMinMix() to ensure drawing tool is fully rendered in chart scale
     IsAutoScale = true;  
   }
   else if (State == State.Configure)
   {
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isautoscale.md)
*   [Property Value](./isautoscale.md)
*   [Syntax](./isautoscale.md)
*   [Examples](./isautoscale.md)