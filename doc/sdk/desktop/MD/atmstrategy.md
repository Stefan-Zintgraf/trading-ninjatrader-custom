**Path**: [Alert and Debug Concepts](./alert_and_debug_concepts.md) > [AtmStrategy](./atmstrategy.md)

# AtmStrategy

# AtmStrategy

AtmStrategy contains properties and methods used to manage [ATM Strategies](./atm_strategy_methods.md). When working with an [AtmStrategySelector](./atmstrategyselector.md), selected objects can be case to AtmStrategy to obtain or change their properties.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  For a complete, working example of this class in use, download framework example located on our [Developing AddOns Overview](./developing_add_ons.md)
2.  For more information on working with the ATM strategies programmatically in general, please see the [Using ATM Strategies](./using_atm_strategies.md) section.

## [Example](./atmstrategy.md)

```csharp
// Using AtmStrategy to handle user selections in an ATM Strategy Selector
myAtmStrategySelector.SelectionChanged += (o, args) =>
{
   if (myAtmStrategySelector.SelectedItem == null)
       return;
   if (args.AddedItems.Count > 0)
   {
       // Change the selected TIF in a TIF selector based on what is selected in the ATM Strategy Selector
       NinjaTrader.NinjaScript.AtmStrategy selectedAtmStrategy = args.AddedItems[0] as NinjaTrader.NinjaScript.AtmStrategy;
       if (selectedAtmStrategy != null)
       {
           myTifSelector.SelectedTif = selectedAtmStrategy.TimeInForce;
       }
   }
};

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Example](./atmstrategy.md)