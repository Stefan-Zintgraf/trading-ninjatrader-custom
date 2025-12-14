**Path**: [BarsRequest](./barsrequest.md) > [MergePolicy](./barsrequest_mergepolicy.md)

# MergePolicy

# MergePolicy

## [Definition](./barsrequest_mergepolicy.md)

Determines the merge policy of the bars request.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property is ONLY applicable to Futures contracts. General information regarding merge policies can be found from the [Market Data Configuration](https://ninjatrader.com/support/helpGuides/nt8/NT%20HelpGuide%20English.html?merge_policy.htm) section. For an Instruments configured merge policy, please see the [MasterInstrument.MergePolicy](./mergepolicy.md) property.

## [Property Value](./barsrequest_mergepolicy.md)

Represents the MergePolicy used for the bars request.

Possible values are:

DoNotMerge

No merge policy is applied

MergeBackAdjusted

Merge policy is applied between contracts along with rollover offsets

MergeNonBackAdjusted

Merge policy is applied between contracts without offsets

UseGlobalSettings

Uses the value configured from Tools \-> Options \-> Market Data

UseDefault

Uses the default values configured for the [MasterInstrument](./masterinstrument.md)

## [Syntax](./barsrequest_mergepolicy.md)

`MergePolicy`

## [Example](./barsrequest_mergepolicy.md)

```csharp
// request the last 365 1 day bars
BarsRequest useGlobalRequest = new BarsRequest(Instrument.GetInstrument("ES 09-16"), 365);
useGlobalRequest.BarsPeriod = new BarsPeriod { BarsPeriodType = BarsPeriodType.Day, Value = 1 };

// use the merge policy the user has configured as their global setting
useGlobalRequest.MergePolicy = MergePolicy.UseGlobalSettings;
useGlobalRequest.Request(new Action<barsrequest, errorcode,="" string="">((barsRequest, errorCode, errorMessage) =>{

   Print("bars returned=" + barsRequest.Bars.Count);

}));

// dispose of the bars request if we are done with it
useGlobalRequest.Dispose();

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./barsrequest_mergepolicy.md)
*   [Property Value](./barsrequest_mergepolicy.md)
*   [Syntax](./barsrequest_mergepolicy.md)
*   [Example](./barsrequest_mergepolicy.md)