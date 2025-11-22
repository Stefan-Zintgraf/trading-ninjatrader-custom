#region Using declarations
using NinjaTrader;
using NinjaTrader.Cbi;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.Data;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui.Tools;
using NinjaTrader.NinjaScript;
using NinjaTrader.NinjaScript.DrawingTools;
using NinjaTrader.NinjaScript.Indicators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
#endregion

//This namespace holds Indicators in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Indicators
{
	public class EdgeTradingOscillator : Indicator
	{
		
		private EMA fast, slow;
		private Series<double> macdLine, rsi_macd_line, rsi_signal_line;
		
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"Enter the description for your new custom Indicator here.";
				Name										= "Edge Trading Oscillator";
				Calculate									= Calculate.OnBarClose;
				IsOverlay									= false;
				DisplayInDataBox							= true;
				DrawOnPricePanel							= true;
				DrawHorizontalGridLines						= true;
				DrawVerticalGridLines						= true;
				PaintPriceMarkers							= true;
				ArePlotsConfigurable 						= true;
				ScaleJustification							= ScaleJustification.Right;
				//Disable this property if your indicator requires custom values that cumulate with each new market data event. 
				//See Help Guide for additional information.
				IsSuspendedWhileInactive					= true;
				
				AddPlot(new Stroke(Brushes.White, 2), PlotStyle.Line, "Fast Line");
				AddPlot(new Stroke(Brushes.Blue, 2), PlotStyle.Line, "Slow Line");
				AddLine(Brushes.SlateGray, 80, "OverBought");
				AddLine(Brushes.SlateGray, 20, "OverSold");
			}
			else if (State == State.Configure)
			{
				macdLine = new Series<double>(this);
				rsi_macd_line = new Series<double>(this);
				rsi_signal_line = new Series<double>(this);
			}
			else if (State == State.DataLoaded)
			{
				fast = EMA(12);
				slow = EMA(26);
			}
		}

		protected override void OnBarUpdate()
		{
			if(CurrentBar < 26)
				return;
			
			macdLine[0] = fast[0] - slow[0];
			
			rsi_macd_line[0] = RSI(macdLine, 14, 3)[0];
			
			rsi_signal_line[0] = SMA(rsi_macd_line, 9)[0];
			
			Values[0][0] = rsi_macd_line[0];
			Values[1][0] = rsi_signal_line[0];
			

			if(CrossAbove(rsi_macd_line, 20, 1) && rsi_signal_line[0] < 20)
				Draw.TriangleUp(this, "TU" + CurrentBar, true, 0, 5, Brushes.Green, false);
			if(CrossBelow(rsi_macd_line, 80, 1) && rsi_signal_line[0] > 80)
				Draw.TriangleDown(this, "TD" + CurrentBar, true, 0, 95, Brushes.Red, false);
			
		}
	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private EdgeTradingOscillator[] cacheEdgeTradingOscillator;
		public EdgeTradingOscillator EdgeTradingOscillator()
		{
			return EdgeTradingOscillator(Input);
		}

		public EdgeTradingOscillator EdgeTradingOscillator(ISeries<double> input)
		{
			if (cacheEdgeTradingOscillator != null)
				for (int idx = 0; idx < cacheEdgeTradingOscillator.Length; idx++)
					if (cacheEdgeTradingOscillator[idx] != null &&  cacheEdgeTradingOscillator[idx].EqualsInput(input))
						return cacheEdgeTradingOscillator[idx];
			return CacheIndicator<EdgeTradingOscillator>(new EdgeTradingOscillator(), input, ref cacheEdgeTradingOscillator);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.EdgeTradingOscillator EdgeTradingOscillator()
		{
			return indicator.EdgeTradingOscillator(Input);
		}

		public Indicators.EdgeTradingOscillator EdgeTradingOscillator(ISeries<double> input )
		{
			return indicator.EdgeTradingOscillator(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.EdgeTradingOscillator EdgeTradingOscillator()
		{
			return indicator.EdgeTradingOscillator(Input);
		}

		public Indicators.EdgeTradingOscillator EdgeTradingOscillator(ISeries<double> input )
		{
			return indicator.EdgeTradingOscillator(input);
		}
	}
}

#endregion
