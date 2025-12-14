**Path**: [SuperDOM Column](./superdom_column.md)

# SuperDOM Column

# SuperDOM Column

Custom SuperDOM Columns can be used to add additional functionality to the **SuperDOM** window. The methods and properties covered in this section are unique to custom SuperDOM column development.

## [In this section](./superdom_column.md)

Method

Description

[MarketDepth](./superdom_marketdepth.md)

Provides Level 2 information for a SuperDOMColumn.

[OnMarketData()](./superdomcolumn_onmarketdata.md)

Called and guaranteed to be in the correct sequence for every change in level one market data for the underlying instrument. The **OnMarketData()** method updates can include but is not limited to the bid, ask, last price and volume.

[OnOrderUpdate()](./superdomcolumn_onorderupdate.md)

Called every time an **order** changes state. An order will change state when a change in order quantity, price or state (e.g. working to filled) occurs.

[OnPositionUpdate()](./superdomcolumn_onpositionupdate.md)

Called every time a **position** changes state.

[OnPropertyChanged()](./onpropertychanged.md)

This method should be used any time you wish to repaint the column instead of calling **OnRender()** directly.

[OnRender()](./superdomcolumn_onrender.md)

Used to draw custom content to the SuperDOM Column, such as a Grid.

[OnRestoreValues()](./onrestorevalues.md)

Called when the column is restored (e.g. from a workspace).

#### ON THIS PAGE

*   [In this section](./superdom_column.md)