**Path**: [System Indicator Methods](./system_indicator_methods.md) > [Order Flow Volume Profile](./order_flow_volume_profile.md)

# Order Flow Volume Profile

# Order Flow Volume Profile

## [Description](./order_flow_volume_profile.md)

The Order Flow Volume Profile indicator is used to plot singular static profiles containing a certain defined range of data or repeating profiles on a per bar or per session basis.

## [Syntax](./order_flow_volume_profile.md)

`OrderFlowVolumeProfile(MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes)`

`OrderFlowVolumeProfile(ISeries<double> input, MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes)`

**Returns the POC value**

`OrderFlowVolumeProfile(MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).Poc`

`OrderFlowVolumeProfile(ISeries<double> input, MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).Poc`

**Returns the ValueAreaHigh value**

`OrderFlowVolumeProfile(MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).ValueAreaHigh`

`OrderFlowVolumeProfile(ISeries<double> input, MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).ValueAreaHigh`

**Returns the ValueAreaLow value**

`OrderFlowVolumeProfile(MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).ValueAreaLow`

`OrderFlowVolumeProfile(ISeries<double> input, MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).ValueAreaLow`

## [Return Value](./order_flow_volume_profile.md)

**double;** Accessing this method property returns the current value.

**Returns the DevelopingPoc value**

`OrderFlowVolumeProfile(MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).DevelopingPoc[int barsAgo]`

`OrderFlowVolumeProfile(ISeries<double> input, MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).DevelopingPoc[int barsAgo]`

**Returns the DevelopingValueAreaHigh value**

`OrderFlowVolumeProfile(MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).DevelopingValueAreaHigh[int barsAgo]`

`OrderFlowVolumeProfile(ISeries<double> input, MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).DevelopingValueAreaHigh[int barsAgo]`

**Returns the DevelopingValueAreaLow value**

`OrderFlowVolumeProfile(MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).DevelopingValueAreaLow[int barsAgo]`

`OrderFlowVolumeProfile(ISeries<double> input, MarketProfileType profileType, MarketProfilePeriod profilePeriod, int sessions, TradingHours tradingHoursInstance, MarketProfileResolution resolution, int valueAreaPercent, int initialBalanceMinutes).DevelopingValueAreaLow[int barsAgo]`

## [RETURN VALUE](./order_flow_volume_profile.md)

**double;** Accessing this method via an index value \[int barsAgo\] returns the indicator value of the referenced bar.

## [Parameters](./order_flow_volume_profile.md)

input

Indicator source data ([Series<`T`\>](./seriest.md))

profileType

The type of profile to generate:

*   Volume
*   Tick
*   Price

profilePeriod

The period used for each profile:

*   Session
*   Bars
*   Composite
*   Weeks
*   Months

sessions

How many sessions will be grouped

tradingHoursInstance

The TradingHours used for the data

resolution

Generate profile using minute or tick data

*   Minute
*   Tick

valueAreaPercent

Range of prices where a specific percentage of trading volume occurs

initialBalanceMinutes

Number of minutes in session range is set

## [Examples](./order_flow_volume_profile.md)

```csharp
// A 1 tick and 1 minute data series must be added to the OnStateChange() as this indicator runs off of tick data or minute data
else if (State == State.Configure)
{
    AddDataSeries(Data.BarsPeriodType.Tick, 1);
    AddDataSeries(Data.BarsPeriodType.Minute, 1);
}

// OnBarUpdate() logic
if (BarsInProgress == 0)
{
    double volumeProfilePoc = OrderFlowVolumeProfile(MarketProfileType.Volume, MarketProfilePeriod.Sessions, 1, BarsArray[0].TradingHours, MarketProfileResolution.Minute, 68, 0).Poc;
    Print("The current Poc is " + volumeProfilePoc.ToString());

    double volumeProfileDevelopingPoc = OrderFlowVolumeProfile(MarketProfileType.Volume, MarketProfilePeriod.Sessions, 1, BarsArray[0].TradingHours, MarketProfileResolution.Minute, 68, 0).DevelopingPoc[0];
    Print(“The DevelopingPoc is “ + volumeProfileDevelopingPoc.ToString());
}
else if (BarsInProgress == 1)
{
    // We have to update the secondary tick series of the cached indicator using Tick Resolution to make sure the values we get in BarsInProgress == 0 are in sync
    OrderFlowVolumeProfile(MarketProfileType.Volume, MarketProfilePeriod.Sessions, 1, BarsArray[0].TradingHours, MarketProfileResolution.Minute, 68, 0).Update(volumeProfile.BarsArray[1].Count - 1, 1);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
// A 1 tick and 1 minute data series must be added to the OnStateChange() as this indicator runs off of tick data or minute data
else if (State == State.Configure)
{
    AddDataSeries(Data.BarsPeriodType.Tick, 1);
    AddDataSeries(Data.BarsPeriodType.Minute, 1);

    // If the tradingHoursInstance parameter for the indicator does not match the primary series, a data series must be added for tick, minute, and primary series bartype / interval using that trading hours
    AddDataSeries(null, new BarsPeriod { BarsPeriodType = BarsPeriodType.Tick, Value = 1 }, "CME US Index Futures RTH");
    AddDataSeries(null, new BarsPeriod { BarsPeriodType = BarsPeriodType.Minute, Value = 1 }, "CME US Index Futures RTH");
    AddDataSeries(null, null, "CME US Index Futures RTH");
}
else if (State == State.DataLoaded)
{
    volumeProfile = OrderFlowVolumeProfile(MarketProfileType.Volume, MarketProfilePeriod.Sessions, 1, TradingHours.String2TradingHours("CME US Index Futures RTH"), MarketProfileResolution.Minute, 68, 0);
    // The TicksPerLevel property is not an overload parameter.
    // once an instance is generated, modify the TicksPerLevel or other properties to the desired values
    volumeProfile.TicksPerLevel = 5;			
}

// OnBarUpdate() logic
if (BarsInProgress == 0)
{
    double volumeProfilePoc = volumeProfile.Poc;
    Print("The current Poc is " + volumeProfilePoc.ToString());

    double volumeProfileDevelopingPoc = volumeProfile.DevelopingPoc[0];
    Print(“The DevelopingPoc is “ + volumeProfileDevelopingPoc.ToString());
}
else if (BarsInProgress == 1)
{
  // We have to update the secondary tick series of the cached indicator using Tick Resolution to make sure the values we get in BarsInProgress == 0 are in sync
  volumeProfile.Update(volumeProfile.BarsArray[1].Count - 1, 1);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Description](./order_flow_volume_profile.md)
*   [Syntax](./order_flow_volume_profile.md)
*   [Return Value](./order_flow_volume_profile.md)
*   [RETURN VALUE](./order_flow_volume_profile.md)
*   [Parameters](./order_flow_volume_profile.md)
*   [Examples](./order_flow_volume_profile.md)