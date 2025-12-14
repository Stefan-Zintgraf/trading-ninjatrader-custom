**Path**: [IInstrumentProvider Interface](./iinstrumentprovider_interface.md)

# IInstrumentProvider Interface

# IInstrumentProvider Interface

When creating your **NTTabPage**, if you wish to use the **instrument link**, be sure to implement the **IInstrumentProvider** interface.

## [Examples](./iinstrumentprovider_interface.md)

```csharp
public class MyWindowTabPage : NTTabPage, IInstrumentProvider
{
     private Instrument instrument;

     public MyWindowTabPage()
     {
         /* Define the content for our NTTabPage. We can load loose XAML to define controls and layouts
         if we so choose here as well.

          Note: XAML with event handlers defined inside WILL FAIL when attempted to load.
          Note: XAML with "inline code" WILL FAIL when attempted to load */
     }

     // IInstrumentProvider member
     public Instrument Instrument
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

    // Be sure to include all the required NTTabPage members as well
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Examples](./iinstrumentprovider_interface.md)