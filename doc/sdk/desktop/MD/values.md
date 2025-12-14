**Contexts**:
- [PriceSeries<double>](./priceseries.md) > [Values](./values.md)
- [Performance Metrics](./performance_metrics.md) > [Values](./values.md)

# Values

# Values

## [Definition](./values.md)

Holds an array of **ISeries<`double`\>** objects holding hold the indicator's underlying calculated values. ISeries<`double`\> values are added to this array when calling the [AddPlot()](./addplot.md) method. In case of a [MultiSeries](./multi_time_frame_instruments.md) indicator synched to the primary series.

## [Property Value](./values.md)

A collection of **ISeries<`double`\>** objects.

## [Syntax](./values.md)

`Values[int index]`

## [Examples](./values.md)

```csharp
// OnBarUpdate method of a custom indicator  
protected override void OnBarUpdate()  
{  
    // Ensures we have enough bars loaded for our indicator  
    if (CurrentBar < 1)  
        return;  
   
    // Evaluates the indicator's secondary value 1 bar ago and sets the value of the indicator  
    // for the current bar being evaluated  
    if (Values[1][1] < High[0] - Low[0])  
        Value[0] = High[0] - Low[0];  
    else  
        Value[0] = High[0] - Close[0];  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./values.md)
*   [Property Value](./values.md)
*   [Syntax](./values.md)
*   [Examples](./values.md)