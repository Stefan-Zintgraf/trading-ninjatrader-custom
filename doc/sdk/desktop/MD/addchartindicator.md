**Path**: [Strategy](./strategy.md) > [AddChartIndicator()](./addchartindicator.md)

# AddChartIndicator()

# AddChartIndicator()

## [Definition](./addchartindicator.md)

Adds an indicator to the strategy only for the purpose of displaying it on a chart.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   Only the Plot properties of an indicator added by AddChartIndicator() will be accessible in the Indicators dialogue on charts. Other properties must be set in code.
*   To add Bars objects to your strategy for calculation purposes see the [AddDataSeries()](./adddataseries.md) method.
*   An indicator being added via AddChartIndicator() cannot use any additional data series hosted by the calling strategy, but can only use the strategy's primary data series. If you wish to use a different data series for the indicator's input, you can add the series in the indicator itself and explicitly reference it in the indicator code (please make sure though the hosting strategy has the same [AddDataSeries()](./adddataseries.md) call included as well)
*   If a secondary or null Bars series is specified by the calling strategy (not the indicator itself), the strategy's primary series will be substituted instead.
*   Dynamically using [DrawOnPricePanel](./drawonpricepanel.md) in an indicator outside of State.SetDefaults may show issues when working with that indicator through a hosting strategy via AddChartIndicator().

## [Method Return Value](./addchartindicator.md)

This method does not return a value.

## [Syntax](./addchartindicator.md)

`AddChartIndicator(IndicatorBase indicator)`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This method should ONLY be called from the [OnStateChange()](./onstatechange.md) method during State.DataLoaded

## [Parameters](./addchartindicator.md)

indicator

An indicator object

## [Examples](./addchartindicator.md)

```csharp
protected override void OnStateChange()
{
     if (State == State.DataLoaded)
     {
         // Charts a 20 period simple moving average to the chart
         AddChartIndicator(SMA(20));
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

If you are adding an indicator which is dependent on the correct [State](./state.md) of the indicator, you will need to ensure that you are also calling the indicator from the strategy in [OnBarUpdate()](./onbarupdate.md), otherwise your indicator will only process in State.RealTime for performance optimizations.

```csharp
protected override void OnStateChange()
{
   if (State == State.DataLoaded)
   {
     // Charts a 20 period simple moving average to the chart
     AddChartIndicator(SMA(20));
   }
}

protected override void OnBarUpdate()
{   
   // call SMA() historically to ensure the indicator processes its historical states as well
   double sma = SMA(20)[0];
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./addchartindicator.md)
*   [Method Return Value](./addchartindicator.md)
*   [Syntax](./addchartindicator.md)
*   [Parameters](./addchartindicator.md)
*   [Examples](./addchartindicator.md)