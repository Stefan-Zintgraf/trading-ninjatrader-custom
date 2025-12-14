**Path**: [ISeries](./iseriest.md) > [GetValueAt()](./getvalueat.md)

# GetValueAt()

# GetValueAt()

## [Definition](./getvalueat.md)

Returns the underlying input value at a specified bar index value.

## [Method Return Value](./getvalueat.md)

A double value representing the value at a specified bar.

## [Syntax](./getvalueat.md)

**GetValueAt**(int barIndex)

**ISeries`<t>`.GetValueAt**(int barIndex)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

If called directly from the instance of the NinjaScript object, the value which is returned corresponds to the input series the object is running. (e.g., Close, High, Low, SMA, etc.). If you're attempting to obtain another indicator value, you will need to pull this from the calculated indicator Value or Plot:

**SMA(20).GetValueAt(123);** // bar value  
**SMA(20).Values\[0\].GetValueAt(123);** // indicator value  
**(Input as Indicator).Values\[0\].GetValueAt(123)** // passed in indicator value

## [Parameters](./getvalueat.md)

Parameter

Description

**barIndex**

An **int** representing an absolute bar index value

## [Examples](./getvalueat.md)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // make sure there are bars displayed on the chart and the chart control is ready before running
    if (Bars == null || chartControl == null)
        return;       

    // loop through all the visible bars on the chart
    for (int i = ChartBars.FromIndex - 1; i >= BarsRequiredToPlot; i--)
    {
        double value = GetValueAt(i);
        Print(string.Format("The value at bar {0} is {1}", i, value));       
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getvalueat.md)
*   [Method Return Value](./getvalueat.md)
*   [Syntax](./getvalueat.md)
*   [Parameters](./getvalueat.md)
*   [Examples](./getvalueat.md)