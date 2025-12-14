**Path**: [NTTabPage Class](./nttabpage.md) > [StartAtmStrategy()](./startatmstrategy.md)

# StartAtmStrategy()

# StartAtmStrategy()

## [Definition](./startatmstrategy.md)

**StartAtmStrategy** can be used to submit entry orders with ATM strategies.

## [Syntax](./startatmstrategy.md)

`NinjaTrader.NinjaScript.AtmStrategy.StartAtmStrategy(AtmStrategy atmStrategyTemplate, Order entryOrder)`

`NinjaTrader.NinjaScript.AtmStrategy.StartAtmStrategy(string atmStrategyTemplateName, Order entryOrder)`

## [Properties](./startatmstrategy.md)

atmStrategyTemplate

An AtmStrategy representing the ATM strategy you wish to use

atmStrategyTemplateName

A string representing the name of the ATM strategy you wish to use

entryOrder

An Order representing the entry order

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

Critical: The "name" argument on the **CreateOrder()** method MUST be named "Entry" for the ATM Strategy to be started successfully.

## [Examples](./startatmstrategy.md)

```csharp
// Example of starting an ATM strategy from an Add On window. The concept can be carried over
// to any NinjaScript object you may be working on.
public class MyAddOnTab : NTTabPage
{
    private Account account;
    private Order entryOrder;

    public MyAddOnTab()
    {
        // Find our Sim101 account
        lock (Account.All)
            account = Account.All.FirstOrDefault(a => a.Name == "Sim101");

        if (account != null)
        {
            entryOrder = account.CreateOrder(Cbi.Instrument.GetInstrument("AAPL"), OrderAction.Buy, OrderType.Market,
                TimeInForce.Day, 1, 0, 0, string.Empty, "Entry", null);

            // Submits our entry order with the ATM strategy named "myAtmStrategyName"
            NinjaTrader.NinjaScript.AtmStrategy.StartAtmStrategy("myAtmStrategyName", entryOrder);
        }
    }

    // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code if building an Add On window.
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./startatmstrategy.md)
*   [Syntax](./startatmstrategy.md)
*   [Properties](./startatmstrategy.md)
*   [Examples](./startatmstrategy.md)