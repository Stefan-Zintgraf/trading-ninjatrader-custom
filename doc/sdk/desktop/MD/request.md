**Path**: [BarsRequest](./barsrequest.md) > [Request()](./request.md)

# Request()

# Request()

## [Definition](./request.md)

Performs the bars request for a **BarsRequest** object

## [Syntax](./request.md)

`BarsRequest.Request(Action<barsrequest, errorcode, string> callback)`

## [Properties](./request.md)

Property

Description

**BarsRequest**

A **BarsRequest** representing the bars

**ErrorCode**

An **ErrorCode** representing error status

**string**

A string representing error message

## [Examples](./request.md)

```csharp
// Request the bars
barsRequest.Request(new Action<barsrequest, errorcode, string>((bars, errorCode, errorMessage) =>
{
     if (errorCode != ErrorCode.NoError)
     {
         // Handle any errors in requesting bars here
         NinjaTrader.Code.Output.Process(string.Format("Error on requesting bars: {0}, {1}",
                                                         errorCode, errorMessage), PrintTo.OutputTab1);
         return;
     }

     // Do something with the returned bars here.
     for (int i = 0; i < bars.Bars.Count; i++)
     {
         // Output the bars
         NinjaTrader.Code.Output.Process(string.Format("Time: {1} Open: {2} High: {3} Low: {4} Close: {5} Volume: {6}",
                                                         bars.Bars.GetTime(i),
                                                         bars.Bars.GetOpen(i),
                                                         bars.Bars.GetHigh(i),
                                                         bars.Bars.GetLow(i),
                                                         bars.Bars.GetClose(i),
                                                         bars.Bars.GetVolume(i)), PrintTo.OutputTab1);
     }
}));

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./request.md)
*   [Syntax](./request.md)
*   [Properties](./request.md)
*   [Examples](./request.md)