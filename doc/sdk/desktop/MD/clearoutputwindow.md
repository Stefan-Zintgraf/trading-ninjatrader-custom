**Path**: [Alert, Debug, Share](./alert_debug_share.md) > [ClearOutputWindow()](./clearoutputwindow.md)

# ClearOutputWindow()

# ClearOutputWindow()

## [Definition](./clearoutputwindow.md)

Clears all data from the NinjaTrader **Output Window**.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The ClearOutputWindow() method only targets the Output tab most recently determined by set **PrintTo** property.

## [Method Return Value](./clearoutputwindow.md)

This method does not return a value.

## [Syntax](./clearoutputwindow.md)

`ClearOutputWindow()`

## [Examples](./clearoutputwindow.md)

```csharp
protected override void OnStateChange()
{       
   if (State == State.SetDefaults)
   {
     Name = "Examples Indicator";   
     Description = @"An indicator used to demonstrate various NinjaScript methods and properties";                    
   }
   else if (State == State.Configure)
   {                
     AddDataSeries(BarsPeriodType.Minute, 5);                
   }   
   
   else if(State == State.DataLoaded)
   {
     //clear the output window as soon as the bars data is loaded
     ClearOutputWindow();         
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./clearoutputwindow.md)
*   [Method Return Value](./clearoutputwindow.md)
*   [Syntax](./clearoutputwindow.md)
*   [Examples](./clearoutputwindow.md)