**Path**: [Bars](./bars.md) > [GetBid()](./getbid.md)

# GetBid()

# GetBid()

## [Definition](./getbid.md)

Returns the bid price value at a selected absolute bar index value.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   This method does NOT return the current real\-time bid price, but rather the historical / real\-time bid price at the desired index. For obtaining the current real\-time bid price, please use **GetCurrentBid()**.
    
*   This method returns expected values when 1 tick bid / ask stamped data is used and available from **your provider**.
    

## [Method Return Value](./getbid.md)

A **double** value that represents the bidding price at the desired bar index.

## [Syntax](./getbid.md)

`Bars.GetBid(int index)`

## [Parameters](./getbid.md)

Parameter

Description

**index**

The absolute bar index value used

## [Examples](./getbid.md)

```csharp
protected override void OnBarUpdate()
{
   // If the Highs of the two most recent bars are falling, place a long stop market order
   // at the Ask price
   if (Low[0] > Low[1] && Low[1] < Low[2])
   {
     EnterShortStopMarket(Bars.GetBid(CurrentBar));
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./getbid.md)
*   [Method Return Value](./getbid.md)
*   [Syntax](./getbid.md)
*   [Parameters](./getbid.md)
*   [Examples](./getbid.md)