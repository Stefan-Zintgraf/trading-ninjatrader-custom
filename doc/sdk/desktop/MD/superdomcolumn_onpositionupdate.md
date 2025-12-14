**Path**: [SuperDOM Column](./superdom_column.md) > [OnPositionUpdate()](./superdomcolumn_onpositionupdate.md)

# OnPositionUpdate()

# OnPositionUpdate()

## [Definition](./superdomcolumn_onpositionupdate.md)

Called every time a position changes state.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The OnPositionUpdate() method is called on ALL position updates (e.g., any account and instrument combination) and NOT just the specific items which are selected in the SuperDOM.

## [Method Return Value](./superdomcolumn_onpositionupdate.md)

This method does not return a value.

## [Syntax](./superdomcolumn_onpositionupdate.md)

`protected override void OnPositionUpdate(PositionEventArgs positionUpdate)`

## [Method Parameters](./superdomcolumn_onpositionupdate.md)

Parameter

Description

**positionUpdate**

A **PositionEventArgs** representing the change in position

## [Examples](./superdomcolumn_onpositionupdate.md)

```csharp
protected override void OnPositionUpdate(PositionEventArgs positionUpdate)
{
  // Do not take action if the position update does not come from the selected SuperDOM instrument/account
  if (positionUpdate.Position.Instrument != SuperDom.Instrument
    || positionUpdate.Position.Account != SuperDom.Account)
    return;

  // Do something
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./superdomcolumn_onpositionupdate.md)
*   [Method Return Value](./superdomcolumn_onpositionupdate.md)
*   [Syntax](./superdomcolumn_onpositionupdate.md)
*   [Method Parameters](./superdomcolumn_onpositionupdate.md)
*   [Examples](./superdomcolumn_onpositionupdate.md)