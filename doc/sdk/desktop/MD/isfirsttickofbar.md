**Path**: [OnBarUpdate()](./onbarupdate.md) > [IsFirstTickOfBar](./isfirsttickofbar.md)

# IsFirstTickOfBar

# IsFirstTickOfBar

## [Definition](./isfirsttickofbar.md)

Indicates if the incoming tick is the first tick of a new bar. This property is only of value in scripts that run tick by tick which is when the **Calculate** property is set to **Calculate.OnEachTick** or **Calculate.OnPriceChange**.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should NOT be accessed outside of the **OnBarUpdate()** method.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

If a bar type is set up to **remove the last bar** on a chart, `IsFirstTickOfBar` will automatically be set to True.

## [Property Value](./isfirsttickofbar.md)

This property returns true if the incoming tick is the first tick of a new bar; otherwise, false.

## [Syntax](./isfirsttickofbar.md)

`IsFirstTickOfBar`

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

In NinjaTrader's event driven framework, bar closures are signaled by the tick that opens the next bar. The price of the last tick of a bar can be referenced by checking **Close\[1\]** on `IsFirstTickOfBar`. For volume and tick based bars, **Bars.TickCount** and **Volume\[0\]** can be referenced to see if the number of ticks / volume meet the criteria to build a new bar.

## [Examples](./isfirsttickofbar.md)

```csharp
// On a tick by tick strategy the only way you know when a bar is closed is when
// the IsFirstTickOfBar is true.
protected override void OnBarUpdate()
{
     // Only process entry signals on a bar by bar basis (not tick by tick)
     if (IsFirstTickOfBar)
     {
         if (CCI(20)[1] < -250)
               EnterLong();
         return;
     }

     // Process exit signals tick by tick
     if (CCI(20)[0] > 250)
         ExitLong();
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isfirsttickofbar.md)
*   [Property Value](./isfirsttickofbar.md)
*   [Syntax](./isfirsttickofbar.md)
*   [Examples](./isfirsttickofbar.md)