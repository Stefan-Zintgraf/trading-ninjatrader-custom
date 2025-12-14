**Path**: [Drawing Tools](./drawing_tools.md) > [AttachedTo](./attachedto.md)

# AttachedTo

# AttachedTo

## [Definition](./attachedto.md)

An object which holds information regarding where the drawing tool is attached.

## [Available Properties](./attachedto.md)

Name

Description

AttachedToType

An enum representing the type of object the drawing tool is attached. Possible values are:

*   Bars \- The chart bars of the parent chart
    
*   GlobalInstrument \- The bars of an instrument across all charts
    
*   Indicator \- A NinjaScript indicator
    
*   Strategy \- A NinjaScript strategy
    

ChartObject

A ChartObject interface such as an indicator, strategy, chart bars

DisplayName

A **string** value indicating the name of the object the drawing tool is attached

Instrument

The Instrument that the drawing tool is attached

## [Syntax](./attachedto.md)

`AttachedTo`

## [Examples](./attachedto.md)

```csharp

if (AttachedTo.AttachedToType == AttachedToType.Indicator)
   // do something


```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./attachedto.md)
*   [Available Properties](./attachedto.md)
*   [Syntax](./attachedto.md)
*   [Examples](./attachedto.md)