**Contexts**:
- [PriceSeries<double>](./priceseries.md) > [Value](./value.md)
- [Optimization Fitness](./optimization_fitness.md) > [Value](./value.md)

# Value

# Value

## [Definition](./value.md)

A collection of historical references to the first ISeries object Values\[0\] in the indicator. This is the primary indicator value (synched to the primary series in case of a [MultiSeries](./multi_time_frame_instruments.md) indicator)

## [Property Value](./value.md)

An ISeries<`double`\> object.

## [Syntax](./value.md)

`Value`

## [Examples](./value.md)

```csharp
// OnBarUpdate method of a custom indicator  
protected override void OnBarUpdate()  
{  
    // Ensures we have enough bars loaded for our indicator  
    if (CurrentBar < 1)  
        return;  
   
    // Evaluates the indicator primary value 1 bar ago and sets the value of the indicator  
    // for the current bar being evaluated  
    if (Value[1] < High[0] - Low[0])  
        Value[0] = High[0] - Low[0];  
    else  
        Value[0] = High[0] - Close[0];  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./value.md)
*   [Property Value](./value.md)
*   [Syntax](./value.md)
*   [Examples](./value.md)