**Path**: [Rendering](./rendering.md) > [SetZOrder](./setzorder.md)

# SetZOrder

# SetZOrder

## [Definition](./setzorder.md)

Used to assign a unique identifier representing the index in which chart objects are drawn on the chart's Z\-axis (front to back ordering). Objects with a higher **ZOrder** are drawn first.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

1.  To check on which **ZOrder** index the object gets drawn use the [ZOrder](./chart_zorder.md) property.
2.  Assigning specific **ZOrder** indices to draw at should be done once the [State](./onstatechange.md) has reached **State.Historical**.
3.  If you want to draw your object behind the bars, assign to use index \-1 (like in the example below).
4.  If you want to draw your object topmost, assign to use index **int.MaxValue**.
5.  Any levels in between can be directly assigned, the starting / default levels used by NinjaTrader can be seen [here](./chart_zorder.md).
6.  You can see the highest **ZOrder** currently in a chart with code such our second example below \- setting higher values than this value will result in the **ZOrder** to be set to this value, so this can be thought of as the current 'top'.

## [Method Return Value](./setzorder.md)

This method does not return a value.

## [Syntax](./setzorder.md)

`SetZOrder(int DesiredZOrderLevel)`

## [Examples](./setzorder.md)

```csharp
protected override void OnStateChange()
{
   if (State == State.Historical)
   {
       // Make sure our object plots behind the chart bars
       SetZOrder(-1);
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

```csharp
protected override void OnRender(ChartControl cc, ChartScale cs)
{
   Print(ChartPanel.ChartObjects.Max(co => co.ZOrder));
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./setzorder.md)
*   [Method Return Value](./setzorder.md)
*   [Syntax](./setzorder.md)
*   [Examples](./setzorder.md)