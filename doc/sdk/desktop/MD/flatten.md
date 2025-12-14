**Path**: [Account Class](./account_class.md) > [Flatten()](./flatten.md)

# Flatten()

# Flatten()

## [Definition](./flatten.md)

Flattens the account on an instrument.

## [Syntax](./flatten.md)

`Flatten(ICollection<instrument> instruments)`

## [Parameters](./flatten.md)

instruments

A collection of Instruments for orders to be cancelled and positions closed

## [Examples](./flatten.md)

### Flatten a single instrument

```csharp
Account.Flatten(new [] { Instrument.GetInstrument("ES 12-15") });

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

### Flatten a list of instruments

```csharp
// Please note that your 'Using declarations' section needs to have
//
// using System.Collections.ObjectModel;
//
//added in order for this example to compile correctly

// instantiate a list of instruments
Collection<cbi.instrument> instrumentsToClose = new Collection<instrument>();

// add instruments to the collection
instrumentsToClose.Add(Instrument.GetInstrument("AAPL"));
instrumentsToClose.Add(Instrument.GetInstrument("MSFT"));

// pass the instrument collection to the Flatten() method to be flattened
Account.Flatten(instrumentsToClose);

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./flatten.md)
*   [Syntax](./flatten.md)
*   [Parameters](./flatten.md)
*   [Examples](./flatten.md)