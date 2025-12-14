**Path**: [ChartAnchor](./chartanchor.md) > [OnBarsChanged()](./onbarschanged.md)

# OnBarsChanged()

# OnBarsChanged()

## [Definition](./onbarschanged.md)

An event driven method which is called any time the underlying bar series have changed for the chart where the drawing tool resides. For example if a user has changed the primary instrument or the time frame of the bars used on the chart.

## [Method Return Value](./onbarschanged.md)

This method does not return a value.

## [Syntax](./onbarschanged.md)

You must override this method using the following syntax:

`public override void OnBarsChanged()`

## [Method Parameters](./onbarschanged.md)

This method does not accept any parameters.

## [Examples](./onbarschanged.md)

```csharp

public override void OnBarsChanged()
{
    //bars have change, do something
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onbarschanged.md)
*   [Method Return Value](./onbarschanged.md)
*   [Syntax](./onbarschanged.md)
*   [Method Parameters](./onbarschanged.md)
*   [Examples](./onbarschanged.md)