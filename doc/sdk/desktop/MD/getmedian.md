**Path**: [Analytical](./analytical.md) > [GetMedian()](./getmedian.md)

# GetMedian()

# GetMedian()

## [Definition](./getmedian.md)

Returns the statistical median value of the specified series over the specified look\-back period. This method sorts the values of the specified look back period in ascending order and returns the middle value.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  This method should NOT be confused with **Median** prices defined as (**High** + **Low**) / 2. This method returns the statistical median of a series.
2.  If an even number is passed as the look\-back period, the average of the two middle values in the sorted values will be returned.

## [Method Return Value](./getmedian.md)

A **double** value representing the median value of the series.

## [Syntax](./getmedian.md)

`GetMedian(ISeries<double> series, int lookBackPeriod)`

## [Parameters](./getmedian.md)

**lookBackPeriod**

Number of bars back to include in the calculation

**series**

Any **Series<`double`\>** type object such as an indicator, **Close**, **High**, **Low**, etc...

## [Examples](./getmedian.md)

```csharp
protected override void OnBarUpdate()
{   
   // Print the median price of the last 10 open prices 
   //(current open price + look back period's 9 open prices before that)
   double openMedian = GetMedian(Open, 9);         
   Print("The median of the last 10 open prices is: " + openMedian);      
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getmedian.md)
*   [Method Return Value](./getmedian.md)
*   [Syntax](./getmedian.md)
*   [Parameters](./getmedian.md)
*   [Examples](./getmedian.md)