**Path**: [Draw.RiskReward()](./draw_riskreward.md) > [RiskReward](./riskreward.md)

# RiskReward

# RiskReward

## [Definition](./riskreward.md)

Represents an interface that exposes information regarding a Risk Reward **IDrawingTool**.

## [Methods and Properties](./riskreward.md)

Parameter

Description

EntryAnchor

An **IDrawingTool's ChartAnchor** representing the entry point of the drawing object

RiskAnchor

An **IDrawingTool's ChartAnchor** representing the stop loss point of the drawing object

RewardAnchor

An **IDrawingTool's ChartAnchor** representing the profit target point of the drawing object

Ratio

An **int** value determining the calculated ratio between the risk or reward based on the entry point

## [Examples](./riskreward.md)

```csharp
// Instantiate a RiskReward object
RiskReward myRR = Draw.RiskReward(this, "tag1", false, 0, High[0], 10, Low[0], 2, true);

// Change the object's risk/reward ratio to 2:1
myRR.Ratio = 2;

```

![copy](/_next/image?url=%2F_next%2Fstatic%2Fmedia%2FCopy.82606927.svg&w=48&q=75)

#### ON THIS PAGE

*   [Definition](./riskreward.md)
*   [Methods and Properties](./riskreward.md)
*   [Examples](./riskreward.md)