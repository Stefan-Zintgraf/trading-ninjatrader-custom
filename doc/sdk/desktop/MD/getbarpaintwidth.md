**Path**: [Chart Style](./chart_style.md) > [GetBarPaintWidth()](./getbarpaintwidth.md)

# GetBarPaintWidth()

# GetBarPaintWidth()

## [Definition](./getbarpaintwidth.md)

Returns the painted width of the chart bar. The **GetBarPaintWidth()** method will return a minimum value of 1.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This is an [abstract](https://msdn.microsoft.com/en-us/library/sf985hc5.aspx) method which is required to compile a ChartStyle object. If you do not plan on recalculating a barWidth, simply return the default barWidth parameter which is passed in this method. Please see the Examples section of this page for more information.

## [Method Return Value](./getbarpaintwidth.md)

An **int** value

## [Syntax](./getbarpaintwidth.md)

You must override this method using the following syntax:

`public override int GetBarPaintWidth(int barWidth) { }`

## [Method Parameters](./getbarpaintwidth.md)

Parameter

Description

**barWidth**

An **int** value representing the current width of the bar to calculate

## [Examples](./getbarpaintwidth.md)

### Returning the default barWidth

```csharp

public override int GetBarPaintWidth(int barWidth)
{
    return barWidth
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

### Calculating and returning a new barWidth from the original barWidth

```csharp
public override int GetBarPaintWidth(int barWidth)
{
    // calculate a new bar width 
    return 1 + 2 * (barWidth - 1) + 2 * (int) Math.Round(Stroke.Width);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getbarpaintwidth.md)
*   [Method Return Value](./getbarpaintwidth.md)
*   [Syntax](./getbarpaintwidth.md)
*   [Method Parameters](./getbarpaintwidth.md)
*   [Examples](./getbarpaintwidth.md)