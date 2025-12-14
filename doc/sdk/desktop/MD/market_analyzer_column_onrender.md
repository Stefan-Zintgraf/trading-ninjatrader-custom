**Path**: [Market Analyzer Column](./market_analyzer_column.md) > [OnRender()](./market_analyzer_column_onrender.md)

# OnRender()

# OnRender()

## [Definition](./market_analyzer_column_onrender.md)

Used to draw custom content to a Market Analyzer Column, such as a graph.

This method is called during the following conditions:

*   The Market Analyzer is scrolled
*   The user changes the Market Analyzer's properties through the Properties menu
*   The Market Analyzer first loads (e.g. restoring from a workspace)
*   The height / width of the Market Analyzer window changes
*   A user re\-sizes the content area by dragging the splitter between the columns

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

While similar to a Chart Indicator's **OnRender()** method, the Market Analyzer Column uses the **WPF Drawing Context** class, rather than the **SharpDX** library used for **chart rendering**. Concepts between these two methods are guaranteed to be different.

## [Method Return Value](./market_analyzer_column_onrender.md)

This method does not return a value.

## [Syntax](./market_analyzer_column_onrender.md)

You must override the method in your Market Analyzer column with the following syntax:

`protected override void OnRender(DrawingContext dc, System.Windows.Size renderSize) { }`

## [Method Parameters](./market_analyzer_column_onrender.md)

Parameter

Description

**dc**

The **drawing context** for the column

**renderSize**

The rendering size for the column

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

In order to force **OnRender()** to be called under a specific condition, call the **OnPropertyChanged()** method which will force the entire column to repaint. This approach should be used instead of calling **OnRender()** directly.

## [Examples](./market_analyzer_column_onrender.md)

```csharp
protected override void OnRender(DrawingContext dc, System.Windows.Size renderSize)
{
   // Rendering logic for our Market Analyzer column
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./market_analyzer_column_onrender.md)
*   [Method Return Value](./market_analyzer_column_onrender.md)
*   [Syntax](./market_analyzer_column_onrender.md)
*   [Method Parameters](./market_analyzer_column_onrender.md)
*   [Examples](./market_analyzer_column_onrender.md)