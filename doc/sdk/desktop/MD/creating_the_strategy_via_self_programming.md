**Path**: [Beginner - Simple MA Cross Over](./beginner_simple_ma_cross_over.md) > [Creating the Strategy via Self Programming](./creating_the_strategy_via_self_programming.md)

# Creating the Strategy via Self Programming

# Creating the Strategy via Self Programming

If you have not done so already, press the "Unlock Code" button within the wizard to launch the NinjaScript Editor.

The **OnBarUpdate()** method is called for each incoming tick or on the close of a bar (user defined) when performing real\-time calculations. Therefore, this is the main method called for strategy calculation and we will use this method to enter the script that checks for entry and exit conditions.

## [The Entry and Exit Condition](./creating_the_strategy_via_self_programming.md)

Enter the code contained within the **OnBarUpdate()** method in the image below into the **OnBarUpdate()** method in the NinjaScript Editor:

```csharp
protected override void OnBarUpdate()
{
    if (CrossAbove(SMA(Fast), SMA(Slow), 1))
        EnterLong();

    if (CrossBelow(SMA(Fast), SMA(Slow), 1))
        EnterShort();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

Translated into English, the code contained within the **OnBarUpdate()** method above reads:

if the fast simple moving average crosses above the slow simple moving average within the last bar, go long

if the fast simple moving average crosses below the slow simple moving average within the last bar, go short

To accomplish this we used the following methods:

*   [CrossAbove](./crossabove.md) \- Checks for a cross above condition and returns true or false
*   [CrossBelow](./crossbelow.md) \- Checks for a cross below condition and returns true or false
*   [SMA](./moving_average_simple_sma.md) \- Returns the value of a simple moving average
*   [EnterLong](./enterlong.md) \- Enters a market order long
*   [EnterShort](./entershort.md) \- Enters a market order short

#### ON THIS PAGE

*   [The Entry and Exit Condition](./creating_the_strategy_via_self_programming.md)