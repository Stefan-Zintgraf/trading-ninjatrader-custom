**Path**: [Draw.VerticalLine()](./draw_verticalline.md) > [RemoveDrawObject()](./removedrawobject.md)

# RemoveDrawObject()

# RemoveDrawObject()

## [Definition](./removedrawobject.md)

Removes a draw object from the chart based on its tag value.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

This method will ONLY remove DrawObjects which were created by a NinjaScript object. User drawn objects CANNOT be removed from via NinjaScript.

## [Method Return Value](./removedrawobject.md)

This method does not return a value.

## [Syntax](./removedrawobject.md)

`RemoveDrawObject(string tag)`

## [Parameters](./removedrawobject.md)

Parameter

Description

**tag**

A user defined unique id used to reference the draw object. For example, if you pass in a value of "myTag", each time this tag is used, the same draw object is modified. If unique tags are used each time, a new draw object will be created each time.

## [Examples](./removedrawobject.md)

```csharp
// Removes a draw object with the tag "tag1"**
RemoveDrawObject("tag1");

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./removedrawobject.md)
*   [Method Return Value](./removedrawobject.md)
*   [Syntax](./removedrawobject.md)
*   [Parameters](./removedrawobject.md)
*   [Examples](./removedrawobject.md)