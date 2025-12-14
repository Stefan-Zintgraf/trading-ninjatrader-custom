**Path**: [Import Type](./import_type.md) > [OnNextDataPoint()](./onnextdatapoint.md)

# OnNextDataPoint()

# OnNextDataPoint()

## [Definition](./onnextdatapoint.md)

The **OnNextDataPoint()** method is called for each line of data contained in the file being imported. This method is only called if the import type determines that the file has a valid data point, and will continue to be called until it reaches the end of the file, or until the data point is no longer valid.

## [Method Return Value](./onnextdatapoint.md)

This method does not return a value.

## [Syntax](./onnextdatapoint.md)

See example below. The [NinjaScript code wizards](./ninjascript_wizard.md) automatically generate the method syntax for you.

## [Examples](./onnextdatapoint.md)

```csharp
private StreamReader reader;
  
protected override void OnNextDataPoint()
{
   if (reader == null)
       return;

   // Continually read data using the StreamReader defined above
   while (true)
   {
       DataPointString = reader.ReadLine();
       // Additional data formatting here
   }
}

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./onnextdatapoint.md)
*   [Method Return Value](./onnextdatapoint.md)
*   [Syntax](./onnextdatapoint.md)
*   [Examples](./onnextdatapoint.md)