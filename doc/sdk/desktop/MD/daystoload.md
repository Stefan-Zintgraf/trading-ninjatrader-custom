**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [DaysToLoad](./daystoload.md)

# DaysToLoad

# DaysToLoad

## [Definition](./daystoload.md)

Determines the number of trading days which will be configured when loading the strategy from the Strategies Grid.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  This property does NOT affect a strategy configured of a Chart or the Strategy Analyzer.
2.  A trading day is defined by a **Trading Hour** template

## [Property Value](./daystoload.md)

An **int** value determining the number of trading days to load for historical data processing. Default value is 5, but can be configured and overridden from the UI.

## [Syntax](./daystoload.md)

`DaysToLoad`

## [Examples](./daystoload.md)

```csharp

protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         DaysToLoad = 15;
     }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./daystoload.md)
*   [Property Value](./daystoload.md)
*   [Syntax](./daystoload.md)
*   [Examples](./daystoload.md)