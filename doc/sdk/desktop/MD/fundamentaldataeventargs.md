**Path**: [OnFundamentalData()](./onfundamentaldata.md) > [FundamentalDataEventArgs](./fundamentaldataeventargs.md)

# FundamentalDataEventArgs

# FundamentalDataEventArgs

## [Definition](./fundamentaldataeventargs.md)

Represents a change in fundamental data and is passed as a parameter in the **OnFundamentalData()** method.

## [Methods and Parameters](./fundamentaldataeventargs.md)

Property/Method

Description

DateTimeValue

A **DateTime** value representing the time

DoubleValue

A **double** value representing fundamental data

FundamentalDataType

Possible values:

*   AverageDailyVolume
*   Beta
*   CalendarYearHigh
*   CalendarYearHighDate
*   CalendarYearLow
*   CalendarYearLowDate
*   CurrentRatio
*   DividendAmount
*   DividendPayDate
*   DividendYield
*   EarningsPerShare
*   FiveYearsGrowthPercentage
*   High52Weeks
*   High52WeeksDate
*   HistoricalVolatility
*   Low52Weeks
*   Low52WeeksDate
*   MarketCap
*   NextYearsEarningsPerShare
*   PercentHeldByInstitutions
*   PriceEarningsRatio
*   RevenuePerShare
*   SharesOutstanding
*   ShortInterest
*   ShortInterestRatio
*   VWAP

IsReset

A bool value representing if a UI reset is needed after a manual disconnect. Note: This is only relevant for columns. Whenever this property is true, the UI needs to be reset.

LongValue

A long value representing fundamental data

ToString()

A string representation of the FundamentalDataEventArgs object

## [Examples](./fundamentaldataeventargs.md)

```csharp
protected override void OnFundamentalData(FundamentalDataEventArgs fundamentalDataUpdate)
{
    // Print some data to the Output window
    if (fundamentalDataUpdate.FundamentalDataType == FundamentalDataType.AverageDailyVolume)
        Print("Average Daily Volume = " + fundamentalDataUpdate.LongValue);
    else if (fundamentalDataUpdate.FundamentalDataType == FundamentalDataType.PriceEarningsRatio)
        Print("P/E Ratio = " + fundamentalDataUpdate.DoubleValue);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   Not all connectivity providers support all FundamentalDataTypes.
*   **EarningsPerShare** on eSignal is a trailing twelve months value. On IQFeed it is the last quarter's value.
*   **RevenuePerShare** is a trailing twelve months value.

#### ON THIS PAGE

*   [Definition](./fundamentaldataeventargs.md)
*   [Methods and Parameters](./fundamentaldataeventargs.md)
*   [Examples](./fundamentaldataeventargs.md)