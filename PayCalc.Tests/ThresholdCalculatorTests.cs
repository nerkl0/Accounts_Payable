using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_programming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_programming.Tests
{
	[TestClass()]
	public class ThresholdCalculatorTests
	{
		[TestMethod()]
		[DataRow(0,358.00)]
		[DataRow(14.8719,437.00)]
		[DataRow(15.1129,438.00)]
		[DataRow(46.7229,547.00)]
		[DataRow(46.9414,548.00)]
		[DataRow(83.0614,720.00)]
		[DataRow(83.2789,721.00)]
		[DataRow(114.5959,864.00)]
		[DataRow(114.8928,865.00)]
		[DataRow(259.5360,1281.00)]
		[DataRow(259.8811,1282.00)]
		[DataRow(613.1612,2306.00)]
		[DataRow(613.5196,2307.00)]
		[DataRow(1063.1896,3460.00)]
		[DataRow(1063.6157,3461.00)]
		public void CalcTaxTest_WithThreshold(double expResult, double weeklyPay)
		{
			string filePath = "../../../taxrate-withthreshold.csv";

			Assert.AreEqual(expResult, ThresholdCalculator.CalcTax(filePath, weeklyPay), 4);
		}

		[TestMethod()]
		[DataRow (16.5281,87.00)]
		[DataRow (16.9310,88.00)]
		[DataRow (83.1446,370.00)]
		[DataRow (83.3661,371.00)]
		[DataRow (114.6831,514.00)]
		[DataRow (114.9800,515.00)]
		[DataRow (259.6232,931.00)]
		[DataRow (259.9684,932.00)]
		[DataRow (613.2484,1956.00)]
		[DataRow (613.6068,1957.00)]
		[DataRow (1063.2768,3110.00)]
		[DataRow (1063.7029,3111.00)]
		public void CalcTaxTest_NoThreshold(double expResult, double weeklyPay)
		{
			string filePath = "../../../taxrate-nothreshold.csv";

			Assert.AreEqual(expResult, ThresholdCalculator.CalcTax(filePath, weeklyPay), 4);
		}
    }
}