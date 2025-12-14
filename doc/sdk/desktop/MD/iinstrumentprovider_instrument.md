**Path**: [IInstrumentProvider Interface](./iinstrumentprovider_interface.md) > [Instrument](./iinstrumentprovider_instrument.md)

# Instrument

# Instrument

In order for instrument linking to work properly in your Add On, **Instrument** must be created.

## [Examples](./iinstrumentprovider_instrument.md)

```csharp

// IInstrumentProvider membepublic Instrument Instrument
{
     get { return instrument; }
     set
     {
         if (instrument != null)
         {
             // Unsubscribe to subscriptions to previously selected instrument
         }

         if (value != null)
         {
             // Create subscriptions for the newly selected instrument
         }

         instrument = value;

         // Send instrument to other windows linked to the same color
         PropagateInstrumentChange(value);

         // Update the tab header name
         RefreshHeader();
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Examples](./iinstrumentprovider_instrument.md)