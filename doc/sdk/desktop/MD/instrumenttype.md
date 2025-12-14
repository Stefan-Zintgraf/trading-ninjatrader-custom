**Path**: [MasterInstrument](./masterinstrument.md) > [InstrumentType](./instrumenttype.md)

# InstrumentType

# InstrumentType

## [Definition](./instrumenttype.md)

Returns the type of instrument.

## [Property Value](./instrumenttype.md)

An **InstrumentType** representing the type of an instrument.

Possible values are:

*   **InstrumentType.Future**
*   **InstrumentType.Stock**
*   **InstrumentType.Index**
*   **InstrumentType.Forex**
*   **InstrumentType.Cfd**
*   **InstrumentType.Cryptocurrency**

## [Syntax](./instrumenttype.md)

`Instrument.MasterInstrument.InstrumentType`

## [Examples](./instrumenttype.md)

```csharp
if (Instrument.MasterInstrument.InstrumentType == InstrumentType.Future)
{
 // Do something
}
else
{
 // Do something else
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Additional Access Information](./instrumenttype.md)

This property can be accessed without a null reference check in the **OnBarUpdate()** event handler. When the **OnBarUpdate()** event is triggered, there will always be an **Instrument** object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (**Instrument** != null)

#### ON THIS PAGE

*   [Definition](./instrumenttype.md)
*   [Property Value](./instrumenttype.md)
*   [Syntax](./instrumenttype.md)
*   [Examples](./instrumenttype.md)
*   [Additional Access Information](./instrumenttype.md)