**Path**: [Instrument](./instrument.md) > [Exchange](./exchange.md)

# Exchange

# Exchange

## [Definition](./exchange.md)

Indicates the current exchange of an instrument

## [Property Value](./exchange.md)

Represents the exchange which is selected for the current instrument.

## [Syntax](./exchange.md)

`Instrument.Exchange`

## [Examples](./exchange.md)

```csharp
protected override void OnBarUpdate()
{
    // Print the exchange of the currently configured instrument
    Print(String.Format("Configured instrument is on the {0} exchange", Instrument.Exchange));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Additional Access Information](./exchange.md)

This property can be accessed without a null reference check in the **OnBarUpdate()** event handler. When the **OnBarUpdate()** event is triggered, there will always be an **Instrument** object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (**Instrument** != null)

#### ON THIS PAGE

*   [Definition](./exchange.md)
*   [Property Value](./exchange.md)
*   [Syntax](./exchange.md)
*   [Examples](./exchange.md)
*   [Additional Access Information](./exchange.md)