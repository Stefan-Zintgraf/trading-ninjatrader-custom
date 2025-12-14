**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [GetTrades()](./gettrades.md)

# GetTrades()

# GetTrades()

## [Definition](./gettrades.md)

Returns a **TradeCollection** object representing all trades that make up the specified position.

## [Method Return Value](./gettrades.md)

A **TradeCollection** object.

## [Syntax](./gettrades.md)

`<tradecollection>.GetTrades(string instrument, string entrySignalName, int instance)`

## [Parameters](./gettrades.md)

**instrument**

An instrument name such as "MSFT"

**entrySignalName**

The name of your entry signal

**instance**

The occurrence to check for (1 is the most recent, 2 is the 2nd most recent position, etc...)

## [Examples](./gettrades.md)

```csharp
protected override void OnBarUpdate()
{
     TradeCollection myTrades = SystemPerformance.AllTrades.GetTrades("MSFT", "myEntrySignal", 1);
     Print("The last position was comprised of " + myTrades.Count + " trades.");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./gettrades.md)
*   [Method Return Value](./gettrades.md)
*   [Syntax](./gettrades.md)
*   [Parameters](./gettrades.md)
*   [Examples](./gettrades.md)