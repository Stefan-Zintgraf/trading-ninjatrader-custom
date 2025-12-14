**Path**: [NTTabPage Class](./nttabpage.md) > [OnWindowSaved()](./onwindowsaved.md)

# OnWindowSaved()

# OnWindowSaved()

## [Definition](./onwindowsaved.md)

Called when the window is saved to a workspace, which is called before **OnWindowDestroyed()**. This method is used to save any custom **XElement** data associated with your window.

## [Method Return Value](./onwindowsaved.md)

This method does not return a value.

## [Syntax](./onwindowsaved.md)

`OnWindowSaved(Window window, XElement element)`

## [Parameters](./onwindowsaved.md)

**window**

A [Window](https://msdn.microsoft.com/en-us/library/system.windows.window(v=vs.110).aspx) object which is being saved to the workspace

**element**

A [XElement](https://msdn.microsoft.com/en-us/library/system.xml.linq.xelement(v=vs.110).aspx) object representing the workspace being saved

## [Examples](./onwindowsaved.md)

```csharp
protected override void OnWindowSaved(Window window, XElement element)
{
    Print("OnWindowSaved for " + window.GetHashCode()); 

    // create a new XElement to save the last state of a custom button to the workspace
    XElement xml = new XElement("SampleAddOn", new XElement("ButtonState", true));

    // e.g.,
    // <sampleaddon>
    //  <buttonstate>true</buttonstate>
    // </sampleaddon>

    // add the new element to the workspace which can be restored later
    element.Add(xml);                    

    //Don't forget to call the base OnWindowSaved method after you've finished your operation.
    base.OnWindowSaved(window, element);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onwindowsaved.md)
*   [Method Return Value](./onwindowsaved.md)
*   [Syntax](./onwindowsaved.md)
*   [Parameters](./onwindowsaved.md)
*   [Examples](./onwindowsaved.md)