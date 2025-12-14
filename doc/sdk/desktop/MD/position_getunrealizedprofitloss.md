**Path**: [Position](./position.md) > [GetUnrealizedProfitLoss()](./position_getunrealizedprofitloss.md)

# GetUnrealizedProfitLoss()

# GetUnrealizedProfitLoss()

## [Definition](./position_getunrealizedprofitloss.md)

Calculates the unrealized PnL for the strategy position.

## [Method Return Value](./position_getunrealizedprofitloss.md)

A **double** value representing the unrealized PnL.

## [Syntax](./position_getunrealizedprofitloss.md)

`Position.GetUnrealizedProfitLoss(PerformanceUnit unit, [double price])`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   If no double argument is provided in the call, the current (real\-time) Last price will be substituted in. In case Tools > Options > Trading > 'Use last price for Pnl' is unchecked or the instrument type is Forex / CFD the bid (for a long position) / ask (for a short position) would be used as a substitute.
    
*   For back\-testing a double price to compare against should be provided like in our example below.
    

## [Parameters](./position_getunrealizedprofitloss.md)

Parameter

Description

**unit**

Possible values: **PerformanceUnit.Currency** **PerformanceUnit.Percent** **PerformanceUnit.Pips** **PerformanceUnit.Points** **PerformanceUnit.Ticks**

**price**

Optional price passed in used to calculate the PnL such as **Close\[0\]**. This value is used as the current price and compared against your entry price for the PnL.

## [Examples](./position_getunrealizedprofitloss.md)

```csharp
protected override void OnBarUpdate()
{
    // If not flat print our unrealized PnL
    if (Position.MarketPosition != MarketPosition.Flat)
        Print("Open PnL: " + Position.GetUnrealizedProfitLoss(PerformanceUnit.Points, Close[0]));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./position_getunrealizedprofitloss.md)
*   [Method Return Value](./position_getunrealizedprofitloss.md)
*   [Syntax](./position_getunrealizedprofitloss.md)
*   [Parameters](./position_getunrealizedprofitloss.md)
*   [Examples](./position_getunrealizedprofitloss.md)