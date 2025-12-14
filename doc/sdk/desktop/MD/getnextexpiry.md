**Path**: [MasterInstrument](./masterinstrument.md) > [GetNextExpiry()](./getnextexpiry.md)

# GetNextExpiry()

# GetNextExpiry()

## [Definition](./getnextexpiry.md)

Returns the current futures expiry compared to the time of the input value used for the method.

## [Method Return Value](./getnextexpiry.md)

A **DateTime** structure

## [Syntax](./getnextexpiry.md)

`Bars.Instrument.MasterInstrument.GetNextExpiry(DateTime afterDate)`

## [Parameters](./getnextexpiry.md)

**afterDate**

A **DateTime** value representing to be compared

## [Examples](./getnextexpiry.md)

```csharp
// Indicates what the current expiry is in the bottom right of the chart
Draw.TextFixed(this, "tag1", "The current expiry is " + Bars.Instrument.MasterInstrument.GetNextExpiry(DateTime.Now).ToString("MM-yy"), TextPosition.BottomRight);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getnextexpiry.md)
*   [Method Return Value](./getnextexpiry.md)
*   [Syntax](./getnextexpiry.md)
*   [Parameters](./getnextexpiry.md)
*   [Examples](./getnextexpiry.md)