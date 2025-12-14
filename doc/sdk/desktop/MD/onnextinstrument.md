**Path**: [Import Type](./import_type.md) > [OnNextInstrument()](./onnextinstrument.md)

# OnNextInstrument()

# OnNextInstrument()

## [Definition](./onnextinstrument.md)

The **OnNextInstrument()** method is called at the beginning of the import process for each file that is being imported. This method is only called after it has determined the file contains a valid instrument.

## [Method Return Value](./onnextinstrument.md)

This method does not return a value.

## [Syntax](./onnextinstrument.md)

See example below. The [NinjaScript code wizard](./ninjascript_wizard.md) automatically generates the method syntax for you.

## [Examples](./onnextinstrument.md)

```csharp
private int currentInstrumentIdx = -1;

public string[] FileNames 
{ get; set; }

protected override void OnNextInstrument()
{
    if (FileNames == null)
        return;

    // Try to read from file into the FileNames array created above
    // Log an error and continue if the data is unreadable
    try
    {
        reader = new StreamReader(FileNames[currentInstrumentIdx]);
    }
    catch (Exception exp)
    {
        NinjaScript.Log(FileNames[currentInstrumentIdx], exp.Message, LogLevel.Error);
        continue;
    }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onnextinstrument.md)
*   [Method Return Value](./onnextinstrument.md)
*   [Syntax](./onnextinstrument.md)
*   [Examples](./onnextinstrument.md)