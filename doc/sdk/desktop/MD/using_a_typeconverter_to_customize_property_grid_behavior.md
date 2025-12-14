**Path**: [Indicator](./indicator_overview.md) > [Using a TypeConverter to Customize Property Grid Behavior](./using_a_typeconverter_to_customize_property_grid_behavior.md)

# Using a TypeConverter to Customize Property Grid Behavior

# Using a TypeConverter to Customize Property Grid Behavior

The default behavior of the NinjaTrader property grid is designed to handle the most basic display of your custom Indicator and Strategy properties. However, there are special cases where you may want to control how unique properties display to other users. Since using a TypeConverter is more of a general C# concept used to convert values between data types (a string to an enum for example), so the possibilities of what you can do are within the bounds of the .NET Framework. This NinjaScript sample was produced to help NinjaScript developers understand how to leverage the IndicatorBaseConverter and StrategyBaseConverter helper classes to customize property grid behavior without affecting general NinjaTrader property behavior.

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

*   NinjaTrader expects custom properties to be of value type or type which implements ICloneable interface
    
*   This reference sample assumes you are familiar with basic C# TypeConverter practices and is intended as a starting point. There are extensive 3rd party guides available online which can help you implement a particular type converter goal not covered in this sample
    

## [Key concepts in this example](./using_a_typeconverter_to_customize_property_grid_behavior.md)

There are 5 use cases demonstrated in this sample which fall into two different categories:

1.  Dynamically manipulate what is displayed on the UI Property Grid
    
    *   Show / hide properties based on secondary input
        
    *   Disable / enable properties based on secondary input
        
2.  Customizing how a property is displayed
    
    *   Display "Friendly" enum values
        
    *   Re\-implement a "bool" CheckBox as "Friendly" a ComboBox
        
    *   Display a custom collection / list with user defined values at run time
        

## [Important related documentation](./using_a_typeconverter_to_customize_property_grid_behavior.md)

### C#

*   [ICloneable Interface](https://msdn.microsoft.com/en-us/library/system.icloneable%28v=vs.110%29.aspx)
*   [PropertyDescriptor Class](https://msdn.microsoft.com/en-us/library/system.componentmodel.propertydescriptor%28v=vs.110%29.aspx)
*   [RefreshPropertiesAttribute](https://msdn.microsoft.com/en-us/library/system.componentmodel.refreshpropertiesattribute(v=vs.110).aspx)
*   [TypeConverter Class](https://msdn.microsoft.com/en-us/library/system.componentmodel.typeconverter%28v=vs.110%29.aspx)
*   [DisplayAttribute Class](https://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations.displayattribute(v=vs.110).aspx)

### NinjaTrader

*   [IndicatorBaseConverter Class](./indicatorbaseconverter.md)
*   [StrategyBaseConverter Class](./strategybaseconverter.md)
*   [TypeConverterAttribute](./typeconverterattribute.md)

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

The reference sample files on this page are written for an indicator using the IndicatorBaseConverter class, but the same key concepts are available to strategies by replacing the StrategyBaseConverter where noted in the sample code.

## [Import instructions](./using_a_typeconverter_to_customize_property_grid_behavior.md)

1.  Download the file contained in this Help Guide topic to your PC desktop
2.  From the Control Center window, select the menu Tools > Import > NinjaScript
3.  Select the downloaded file

## [Additional resources](./using_a_typeconverter_to_customize_property_grid_behavior.md)

MSDN \- How to: [Implement a Type Converter](https://msdn.microsoft.com/en-us/library/ayybcxe5.aspx)

[SampleIndicatorTypeConverter\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleIndicatorTypeConverter_NT8.zip)

#### ON THIS PAGE

*   [Key concepts in this example](./using_a_typeconverter_to_customize_property_grid_behavior.md)
*   [Important related documentation](./using_a_typeconverter_to_customize_property_grid_behavior.md)
*   [Import instructions](./using_a_typeconverter_to_customize_property_grid_behavior.md)
*   [Additional resources](./using_a_typeconverter_to_customize_property_grid_behavior.md)