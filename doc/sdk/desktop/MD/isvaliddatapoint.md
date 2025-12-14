**Path**: [ISeries](./iseriest.md) > [IsValidDataPoint()](./isvaliddatapoint.md)

# IsValidDataPoint()

# IsValidDataPoint()

## [Definition](./isvaliddatapoint.md)

Indicates if the specified input is set at a barsAgo value relative to the current bar. Please also see the **[Reset()](./reset.md)** method for more information.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   If called directly from the instance of the **NinjaScript** object, the value returned corresponds to the Input Series (e.g., Close, High, Low, SMA, etc.)
*   When checking a **[Bar](./bars.md)** or **[PriceSeries](./priceseries.md)**, `IsValidDataPoint()` returns true as long as the barsAgo value falls between 0 and the total count for that series. These are special series which always contain a value set at every slot index for multi\-series scripting purposes (e.g., comparing two price series with various session templates, or one series has more ticks than the other)
*   For a **[Value](./value.md)** series or custom **[Series<`t`\>](./seriest.md)**, `IsValidDataPoint()` returns true or false depending on if you have set a value at that index location

## [Method Return Value](./isvaliddatapoint.md)

A bool value, when true indicates that specified data point is set; otherwise false.

## [Syntax](./isvaliddatapoint.md)

`IsValidDataPoint(int barsAgo)`

`ISeries<t>.IsValidDataPoint(int barsAgo)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

*   Calling `IsValidDataPoint()` will only work on a MaximumBarsLookBackInfinite series. Attempting to check **IsValidDataPoint()** on MaximumBarsLookBack256 series will throw an error. Please check the Log tab of the Control Center. In addition, since this method references barsAgo data, it cannot be used during **[OnRender (see note 5)](./onrender.md)** \- instead please use the **[IsValidDataPointAt](./isvaliddatapointat.md)** during OnRender.

## [Parameters](./isvaliddatapoint.md)

barsAgo

An int representing from the current bar the number of historical bars the method will check.

## [Examples](./isvaliddatapoint.md)

```csharp
protected override void OnBarUpdate()
{
   // only set plot value if hosted indicator is not reset
   if(SMA(20).IsValidDataPoint(0))
     MyPlot[0] = SMA(20)[0];
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isvaliddatapoint.md)
*   [Method Return Value](./isvaliddatapoint.md)
*   [Syntax](./isvaliddatapoint.md)
*   [Parameters](./isvaliddatapoint.md)
*   [Examples](./isvaliddatapoint.md)