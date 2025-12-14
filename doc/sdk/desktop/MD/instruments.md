**Path**: [Instrument](./instrument.md) > [Instruments](./instruments.md)

# Instruments

# Instruments

## [Definition](./instruments.md)

A collection of **Instrument** objects currently used by a script.

## [Property Value](./instruments.md)

An array of [Instrument](./instrument.md) objects

## [Syntax](./instruments.md)

`Instruments[]`

## [Examples](./instruments.md)

```csharp
protected override void OnStateChange()
{
   if (State == State.DataLoaded)
   {
       // Print all instruments which have been loaded
       foreach (Instrument i in Instruments)
       {
           Print(i.FullName);
       }
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./instruments.md)
*   [Property Value](./instruments.md)
*   [Syntax](./instruments.md)
*   [Examples](./instruments.md)