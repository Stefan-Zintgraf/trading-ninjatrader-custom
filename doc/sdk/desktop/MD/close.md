**Path**: [PriceSeries<double>](./priceseries.md) > [Close](./close.md)

# Close

# Close

## [Definition](./close.md)

A collection of historical bar close prices.

## [Property Value](./close.md)

A **ISeries`<double>`** type object. Accessing this property via an index value **int barsAgo** returns A **double** value representing the price of the referenced bar.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

When an indicator uses another indicator as input series, Close will represent the closing price of the input series' input series. For example, if MyCustomIndicator uses an ADX as input series, then referencing **Close\[0\]** in MyCustomIndicator will provide the Close price for the ADX's input series.

## [Syntax](./close.md)

`Close`

`Close[int barsAgo]`

## [Examples](./close.md)

```csharp
protected override void OnBarUpdate()
{
     // Evaluates if the current close is greater than the prior bar close
     if (Close[0] > Close[1])
         Print("We had an up day");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./close.md)
*   [Property Value](./close.md)
*   [Syntax](./close.md)
*   [Examples](./close.md)