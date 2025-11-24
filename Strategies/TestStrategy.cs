//
// Copyright (C) 2025, NinjaTrader LLC <www.ninjatrader.com>.
// NinjaTrader reserves the right to modify or overwrite this NinjaScript component with each release.
//
#region Using declarations
using System.ComponentModel.DataAnnotations;
using NinjaTrader.Cbi;
using NinjaTrader.NinjaScript;
#endregion

//This namespace holds strategies in this folder and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Strategies
{
	public class TestStrategy : Strategy
	{
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description	= @"Simple strategy that enters long when price exceeds a threshold value, with 2% stop loss and 2% take profit.";
				Name		= "TestStrategy";
				ThresholdValue = 100;
				StopLossPercent = 2;
				TakeProfitPercent = 2;
			}
			else if (State == State.Configure)
			{
				// Set stop loss and take profit calculation mode to percentage
				SetStopLoss(CalculationMode.Percent, StopLossPercent/100.0);
				SetProfitTarget(CalculationMode.Percent, TakeProfitPercent/100.0);
			}
		}

		protected override void OnBarUpdate()
		{
			if (CurrentBar < BarsRequiredToTrade)
				return;

			// Enter long when close price exceeds threshold value
			if (Position.MarketPosition == MarketPosition.Flat && Close[0] > ThresholdValue)
			{
				EnterLong();
			}
		}

		#region Properties
		[NinjaScriptProperty]
		[Range(0.01, double.MaxValue)]
		[Display(Name = "Threshold Value", Description = "Price level to exceed for long entry", GroupName = "Parameters", Order = 0)]
		public double ThresholdValue { get; set; }

		[NinjaScriptProperty]
		[Range(0.01, 100)]
		[Display(Name = "Stop Loss %", Description = "Stop loss percentage below entry", GroupName = "Parameters", Order = 1)]
		public double StopLossPercent { get; set; }

		[NinjaScriptProperty]
		[Range(0.01, 100)]
		[Display(Name = "Take Profit %", Description = "Take profit percentage above entry", GroupName = "Parameters", Order = 2)]
		public double TakeProfitPercent { get; set; }
		#endregion
	}
}

