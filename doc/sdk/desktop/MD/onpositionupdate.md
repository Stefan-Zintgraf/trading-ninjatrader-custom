**Path**: [OnAccountItemUpdate()](./onaccountitemupdate.md) > [OnPositionUpdate()](./onpositionupdate.md)

# OnPositionUpdate()

# OnPositionUpdate()

## [Definition](./onpositionupdate.md)

An event driven method which is called each time a PositionUpdate is received for the strategy.

*   This method is typically called after [OnExecutionUpdate()](./onexecutionupdate.md).
*   OnPositionUpdate() will update with PositionUpdates that are filtered for the strategy. The strategy [Position](./position.md) object is driven by Executions, and is updated as early as [OnExecutionUpdate()](./onexecutionupdate.md).

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   You will NOT receive position updates for manually placed orders, or orders managed by other strategies (including any [ATM strategies](./using_atm_strategies.md)) in OnPositionUpdate(). The Account class contains a pre\-built event handler ([PositionUpdate](./positionupdate.md)) which can be used to filter position updates on a specified account.
*   It's best practice to only work with the passed by value parameters and not reference parameters. This insures that you process each change of the underlying state.
*   Rithmic and Interactive Brokers Users: When using a NinjaScript strategy it is best practice to only work with passed by value data from OnExecution. Instances of multiple fills at the same time for the same instrument might result in an incorrect OnPositionUpdate, as sequence of events are not guaranteed due to provider API design. For an example on protecting positions with this approach, see [OnExecutionUpdate()](./onexecutionupdate.md).

## [Method Return Value](./onpositionupdate.md)

This method does not return a value.

## [Syntax](./onpositionupdate.md)

You must override the method in your strategy with the following syntax:

`protected override void OnPositionUpdate(Position position, double averagePrice, int quantity, MarketPosition marketPosition)`

## [Method Parameters](./onpositionupdate.md)

Parameter

Description

position

A [Position](./position.md) object passed by reference representing the current position object

averageFillPrice

A double value representing the updating average fill price of a position

quantity

An int value representing the updating quantity of a position

marketPosition

A [MarketPosition](./marketposition.md) object representing the updating position update provided directly from the broker. This is not the actual Position core position object, but the last change of the market position

MarketPosition.Flat

MarketPosition.Long

MarketPosition.Short

## [Examples](./onpositionupdate.md)

```csharp
protected override void OnPositionUpdate(Cbi.Position position, double averagePrice,
      int quantity, Cbi.MarketPosition marketPosition)
{
  if (position.MarketPosition == MarketPosition.Flat)
  {
    // Do something like reset some variables here
  }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

### Understanding the order object parameter vs updating value parameter ([Multi\-Thread Considerations for NinjaScript](./multi_threading_consideration_for_ninjascript.md))

```csharp
protected override void OnPositionUpdate(Cbi.Position position, double averagePrice,
      int quantity, Cbi.MarketPosition marketPosition)
{
  Print("The most current MarketPosition is: " + position.MarketPosition);   // Flat
  Print("This particular position update marketPosition is: " + marketPosition); // Long
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

## [Additional Reference Samples](./onpositionupdate.md)

Additional reference code samples are available in the [NinjaScript Educational Resources](./educational_resources.md) section.

#### ON THIS PAGE

*   [Definition](./onpositionupdate.md)
*   [Method Return Value](./onpositionupdate.md)
*   [Syntax](./onpositionupdate.md)
*   [Method Parameters](./onpositionupdate.md)
*   [Examples](./onpositionupdate.md)
*   [Additional Reference Samples](./onpositionupdate.md)