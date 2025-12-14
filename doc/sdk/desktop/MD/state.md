**Path**: [OnStateChange()](./onstatechange.md) > [State](./state.md)

# State

# State

## [Definition](./state.md)

Represents the current progression of the object as it advances from setup, processing data, to termination. These states can be used for setting up or declaring various resources and properties.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

More detailed explanation of various states along with examples can be found in the **OnStateChange()** method section of this help guide. You can also attempt to set a new State using the **SetState()** method.

## [Property Value](./state.md)

An enum value representing the current state of the object. Possible values are:

State

Description

**SetDefaults**

Default values are set (pushed to UI).

**Configure**

User the presses the OK or Apply button.

**Active**

Object is configured and is ready to receive instructions.

**DataLoaded**

All data series have been loaded.

**Historical**

Begins to process historical data.

**Transition**

Finished processing historical data.

**Realtime**

Begins to process realtime data.

**Terminated**

Begins to shut down.

## [Syntax](./state.md)

`State`

## [Examples](./state.md)

### **Understanding the sequence of States**

```csharp
protected override void OnStateChange()
{
  Print(DateTime.Now + ": Current State is State." + State);
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

### **Using State to only process real\-time data**

```csharp
protected override void OnBarUpdate()
{
   // only process real-time OnBarUpdate events
   if (State == State.Historical)
     return;
       
   //rest of logic           
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./state.md)
*   [Property Value](./state.md)
*   [Syntax](./state.md)
*   [Examples](./state.md)