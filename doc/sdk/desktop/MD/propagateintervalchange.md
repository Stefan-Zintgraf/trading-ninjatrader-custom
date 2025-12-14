**Path**: [NTTabPage Class](./nttabpage.md) > [PropagateIntervalChange()](./propagateintervalchange.md)

# PropagateIntervalChange()

# PropagateIntervalChange()

## [Definition](./propagateintervalchange.md)

In an **NTWindow**, **PropagateIntervalChange()** sends an interval to other windows with the same Interval Linking color configured.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   A public BarsPeriod property must be defined in order to use **PropagateIntervalChange()**, as in the example below.
*   For a complete, working example of this class in use, download the framework example located on our [Developing AddOns Overview](./developing_add_ons.md).

## [Examples](./propagateintervalchange.md)

```csharp
// This custom method will be fired when an interval selector in a custom NTTabPage changes intervals
private void OnIntervalChanged(object sender, BarsPeriodEventArgs args)
{
   if (args.BarsPeriod == null)
       return;

   PropagateIntervalChange(args.BarsPeriod);
}


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./propagateintervalchange.md)
*   [Examples](./propagateintervalchange.md)