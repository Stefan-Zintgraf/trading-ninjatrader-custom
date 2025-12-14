**Path**: [SessionIterator](./sessioniterator.md) > [IsNewSession()](./isnewsession.md)

# IsNewSession()

# IsNewSession()

## [Definition](./isnewsession.md)

Indicates a specified time is greater than the **ActualSessionEnd** property on the configured Trading Hours template.

## [Property Value](./isnewsession.md)

A bool value when true indicates the specified time is later than **ActualSessionEnd**; otherwise false.

## [Parameters](./isnewsession.md)

**time**

The DateTime value used to compare

**includesEndTimeStamp**

A bool determining if a timestamp of <`n`\>:00 should fall into the current session. (e.g., used for time based intraday series such as minute or second).

## [Syntax](./isnewsession.md)

`<sessioniterator>.IsNewSession(DateTime time, bool includesEndTimeStamp)`

## [Examples](./isnewsession.md)

```csharp
bool takeTrades;

protected override void OnBarUpdate()
{
    // Switch a bool named takeTrades to false when IsNewSession() returns true. 
    if (Bars.SessionIterator.IsNewSession(DateTime.Now, true)) ;
    {
        Alert("EOS", Priority.Medium, String.Format("New session beginning. Waiting until {0} to begin trading again"), " ", 5, Brushes.Black, Brushes.White);
        takeTrades = false;
    }

    // Set the bool back to true on the first bar of the new session
    if (Bars.IsFirstBarOfSession)
        takeTrades = true;
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./isnewsession.md)
*   [Property Value](./isnewsession.md)
*   [Parameters](./isnewsession.md)
*   [Syntax](./isnewsession.md)
*   [Examples](./isnewsession.md)