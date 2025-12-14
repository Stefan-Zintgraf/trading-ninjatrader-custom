**Path**: [PriceSeries<double>](./priceseries.md) > [Typicals](./typicals.md)

# Typicals

# Typicals

## [Definition](./typicals.md)

Holds an array of **ISeries<`double`\>** objects holding historical bar typical prices. An ISeries<`double`\> object is added to this array when calling the [AddDataSeries()](./adddataseries.md) method. Its purpose is to provide access to the typical prices of all Bars objects in a multi\-instrument or multi\-time frame script.

## [Property Value](./typicals.md)

An array of [ISeries<`double`\>](./iseriest.md) objects.

## [Syntax](./typicals.md)

`Typicals[int barSeriesIndex][int barsAgo]`

## [Examples](./typicals.md)

```csharp
protected override void OnStateChange()  
{  
    if (State == State.Configure)  
    {  
        // Adds a 5 minute Bars object to the strategy and is automatically assigned  
        // a Bars object index of 1 since the primary data the strategy is run against  
        // set by the UI takes the index of 0.  
        AddDataSeries("AAPL", BarsPeriodType.Minute, 5);  
    }  
}  
   
protected override void OnBarUpdate()  
{  
    // Compares the primary bar's typical price to the 5-minute bar's typical price  
    if (Typicals[0][0] > Typicals[1][0])  
        Print("The primary bar's typical price is greater");  
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./typicals.md)
*   [Property Value](./typicals.md)
*   [Syntax](./typicals.md)
*   [Examples](./typicals.md)