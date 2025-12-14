**Path**: [IIntervalProvider Interface](./iintervalprovider_interface.md)

# IIntervalProvider Interface

# IIntervalProvider Interface

When creating your **NTTabPage**, if you wish to use the **interval link**, be sure to implement the **IIntervalProvider** interface.

## [Examples](./iintervalprovider_interface.md)

```csharp

public class MyWindowTabPage : NTTabPage, IIntervalProvider
{
     public MyWindowTabPage()
     {
         /* Define the content for our NTTabPage. We can load loose XAML to define controls and layouts
         if we so choose here as well.

          Note: XAML with event handlers defined inside WILL FAIL when attempted to load.
          Note: XAML with "inline code" WILL FAIL when attempted to load */
     }

    // IIntervalProvider member
    public BarsPeriod BarsPeriod { get; set; }

    // Be sure to include all the required NTTabPage members as well
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Examples](./iintervalprovider_interface.md)