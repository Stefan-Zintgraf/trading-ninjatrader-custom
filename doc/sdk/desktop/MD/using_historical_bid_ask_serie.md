**Path**: [Intermediate - RSI with Stop Loss & Profit Target](./intermediate_rsi_with_stop_loss_profit_target.md) > [Using Historical Bid/Ask Series](./using_historical_bid_ask_serie.md)

# Using Historical Bid/Ask Series

# Using Historical Bid/Ask Series

## [Historical Bid/Ask Series Overview](./using_historical_bid_ask_serie.md)

NinjaTrader has the ability to use historical bid and ask price series in your NinjaScript instead of only being able to use a last price series. The following outlines the intricacies of this capability:

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   You can have multiple bid/ask/last series in your NinjaScript indicator/strategy. Please use the [AddDataSeries()](./adddataseries.md) method to add these series to your script.
    
*   The historical bid/ask series holds all bid/ask events sent out by the exchange. This would not be equivalent to the bid/ask at a specific time a trade went off.
    
*   When processing your NinjaScript, the historical bid/ask series would have the historical portion triggered in the [OnBarUpdate()](./onbarupdate.md) method only. [OnMarketData()](./onmarketdata.md) method events for the historical bid/ask series would only be triggered in real\-time.
    

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

Tips:

*   For using OnMarketData() events historically, please see the educational topic on [Developing for Tick Replay](./developing_for_tick_replay.md).
    
*   Changing the price type used for the primary Bars object to which a script is applied can be done in the Data Series window from any open chart.
    

## [Accessing Bid/Ask Series](./using_historical_bid_ask_serie.md)

When calling [AddDataSeries()](./adddataseries.md) to add an additional [Bars](./bars.md) object to your script, a constructor overload will be available which takes a MarketDataType enumeration as an argument. This will allow you to specify the price series which will be used in that particular object. If you were to pass in MarketDataType.Ask or MarketDataType.Bid, as in the example below, that particular data series will use that price type for all of its [PriceSeries](./priceseries.md) collections, such as [Close](./close.md), [Open](./open.md), [High](./high.md), and [Low](./low.md).

## [Example](./using_historical_bid_ask_serie.md)

```csharp
protected override void OnStateChange()
{
  if (State == State.Configure)
  {
      // Add an AAPL data series using the Ask series
      AddDataSeries("AAPL", BarsPeriodType.Minute, 30, MarketDataType.Ask);

      //Add another AAPL data series using the Bid series, with other settings identical
      AddDataSeries("AAPL", BarsPeriodType.Minute, 30, MarketDataType.Bid);
  }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Historical Bid/Ask Series Overview](./using_historical_bid_ask_serie.md)
*   [Accessing Bid/Ask Series](./using_historical_bid_ask_serie.md)
*   [Example](./using_historical_bid_ask_serie.md)