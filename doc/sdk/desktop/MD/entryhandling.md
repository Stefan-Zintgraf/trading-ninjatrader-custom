**Path**: [ATM Strategy Methods](./atm_strategy_methods.md) > [EntryHandling](./entryhandling.md)

# EntryHandling

# EntryHandling

## [Definition](./entryhandling.md)

Sets the manner in how entry orders will handle.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This property ONLY applies to Managed order methods. When **IsUnmanaged** is set to true, Entry Handling properties will be hidden from the UI.

## [Property Value](./entryhandling.md)

An enum which sets how the entry orders are handled. Default value is **EntryHandling.AllEntries**. Possible values include:

**EntryHandling.AllEntries**

NinjaScript will process all [order entry methods](./order_methods.md) until the maximum allowable entries set by the [EntriesPerDirection](./entriesperdirection.md) property is reached while in an open position

**EntryHandling.UniqueEntries**

NinjaScript will process order entry methods until the maximum allowable entries set by the EntriesPerDirection property per each uniquely named entry

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FWarning.3bcf24ba.svg&w=64&q=75)

## Warning

This property should ONLY be set from the **OnStateChange()** method during State.SetDefaults or State.Configure.

## [Syntax](./entryhandling.md)

`EntryHandling`

## [Examples](./entryhandling.md)

### Allow a maximum of two entries while a position is open

```csharp
// Example #1
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         EntriesPerDirection = 2;
         EntryHandling = EntryHandling.AllEntries;
     }
}

protected override void OnBarUpdate()
{
     if (CrossAbove(SMA(10), SMA(20), 1)
         EnterLong("SMA Cross Entry");
}

// EnterLong() will be processed once for each uniquely named entry.

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

### Allow a maximum of one entry per uniquely named entry

```csharp
// Example #2
protected override void OnStateChange()
{
     if (State == State.SetDefaults)
     {
         EntriesPerDirection = 1;
         EntryHandling = EntryHandling.UniqueEntries;
     }
}

protected override void OnBarUpdate()
{
     if (CrossAbove(SMA(10), SMA(20), 1)
         EnterLong("SMA Cross Entry");

    if (CrossAbove(RSI(14, 3), 30, 1)
         EnterLong("RSI Cross Entry");
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./entryhandling.md)
*   [Property Value](./entryhandling.md)
*   [Syntax](./entryhandling.md)
*   [Examples](./entryhandling.md)