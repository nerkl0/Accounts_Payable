using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OO_programming
{
	/// <summary>
	/// Class for returning the tax calculated using the correct tax thresholds
	/// </summary>
	public class ThresholdCalculator
	{
		private double _a;
		private double _b;
		private double _min;
		private double _max;

		public ThresholdCalculator(double min, double max, double a, double b)
		{
			_min = min;
			_max = max;
			_a = a;
			_b = b;
		}

		/// <summary>
		/// Reads the file given based on the employees threshold claim
		/// assigns the correct tax bracket values & performs the 
		/// tax calculation
		/// </summary>
		/// <param name="filePath">path to the requested tax threshold file</param>
		/// <param name="weeklyPay">gross pay employee has earned for the week</param>
		/// <returns>calculated tax on that amount</returns>
		/// <exception cref="NumberOutsideOfRange"></exception>
		public static double CalcTax(string filePath, double weeklyPay)
		{
			List<ThresholdCalculator> thresholdData = FileHandling.LoadTaxData(filePath);

			foreach (var data in thresholdData)
			{
				if (weeklyPay >= data._min && weeklyPay < data._max)
				{
					return data._a * weeklyPay - data._b;
				}
			}
			throw new NumberOutsideOfRange();
		}
	}
}
