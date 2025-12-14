**Path**: [VolumeSeries<double>](./volumeseries.md)

# VolumeSeries<double>

# VolumeSeries<double>

## [Definition](./volumeseries.md)

Represents historical volume data as ISeries<`double`\> interface which can be used for custom NinjaScript object calculations

![note image](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FNote.57c6078c.svg&w=64&q=75)

## Note

In most cases, you will access the historical volume series using a core event handler such as OnBarUpdate.  For more advance developers, you may find situations where you wish to access historical volume series outside of the core event methods, such as your own custom mouse click.  In these advanced scenarios, you may run into situations where the barsAgo pointer is not in sync with the current bar, which may cause errors when trying to obtain this information.  In those cases, use the Bars.Get...() methods with the absolute bar index, e.g., [Bars.GetVolume()](./getvolume.md).

## [Single ISeries<`double`\>](./volumeseries.md)

[Volume](./volume.md)

A collection of historical bar volume values.

## [Multi\-Time Frame ISeries<`double`\>](./volumeseries.md)

[Volumes](./volumes.md)

Holds an array of ISeries<`double`\> objects holding historical bar volume.

#### ON THIS PAGE

*   [Definition](./volumeseries.md)
*   [Single ISeries<](./volumeseries.md)
*   [Multi\-Time Frame ISeries<](./volumeseries.md)