**Path**: [OnFundamentalData()](./onfundamentaldata.md)

# OnFundamentalData()

# OnFundamentalData()

## [Definition](./onfundamentaldata.md)

An event driven method which is called for every change in fundamental data for the underlying instrument.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This method is NOT called on historical data (backtest).

## [Method Return Value](./onfundamentaldata.md)

This method does not return a value.

## [Syntax](./onfundamentaldata.md)

You must override the method in your strategy or indicator with the following syntax.

**protected override void OnFundamentalData(FundamentalDataEventArgs fundamentalDataUpdate)**

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The NinjaScript code wizards can automatically generate the method syntax for you when creating a new script.

## [Parameters](./onfundamentaldata.md)

Parameter

Description

**fundamentalDataUpdate**

[FundamentalDataEventArgs](./fundamentaldataeventargs.md) representing the recent change in fundamental data

## [Examples](./onfundamentaldata.md)

```csharp
protected override void OnFundamentalData(FundamentalDataEventArgs fundamentalDataUpdate)
{
    // Print some data to the Output window
    if (fundamentalDataUpdate.FundamentalDataType == FundamentalDataType.AverageDailyVolume)
        Print("The current ADV is " + fundamentalDataUpdate.LongValue);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  With [multi\-time frame and instrument strategies](./multi_time_frame_instruments.md), OnFundamentalData() will be called for all unique instruments in your strategy. Use the [BarsInProgress](./barsinprogress.md) to filter the OnFundamentalData() method for a specific instrument.
2.  Do not leave an unused OnFundamentalData() method declared in your NinjaScript object. This will unnecessarily attach a data stream to your script which uses unnecessary CPU cycles.

#### ON THIS PAGE

*   [Definition](./onfundamentaldata.md)
*   [Method Return Value](./onfundamentaldata.md)
*   [Syntax](./onfundamentaldata.md)
*   [Parameters](./onfundamentaldata.md)
*   [Examples](./onfundamentaldata.md)