**Path**: [Instrument](./instrument.md) > [FullName](./fullname.md)

# FullName

# FullName

## [Definition](./fullname.md)

Indicates the full NinjaTrader name of an instrument. For futures, this would include the expiration date. The September S&P 500 Emini contract full name is "ES 09\-16".

## [Property Value](./fullname.md)

A string representing the full name of the instrument.

## [Syntax](./fullname.md)

`Instrument.FullName`

## [Examples](./fullname.md)

```csharp

protected override void OnBarUpdate()
{
   // Print the full name (including contract month) of the configured instrument
   Print(String.Format("{0} is being used as the input series", Instrument.FullName));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Additional Access Information](./fullname.md)

This property can be accessed without a null reference check in the **OnBarUpdate()** event handler. When the **OnBarUpdate()** event is triggered, there will always be an **Instrument** object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (**Instrument** != null)

#### ON THIS PAGE

*   [Definition](./fullname.md)
*   [Property Value](./fullname.md)
*   [Syntax](./fullname.md)
*   [Examples](./fullname.md)
*   [Additional Access Information](./fullname.md)