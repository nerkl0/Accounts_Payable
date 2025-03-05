using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_programming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace OO_programming.Tests
{
	[TestClass()]
	public class FileHandlingTests
	{
		[TestMethod()]
		public void LoadTaxDataTest_WithThreshold()
		{ 
			Assert.AreEqual(9, FileHandling.LoadTaxData("../../../taxrate-withthreshold.csv").Count());
		}

		[TestMethod()]
		public void LoadTaxDataTest_NoThreshold()
		{
			Assert.AreEqual(7, FileHandling.LoadTaxData("../../../taxrate-nothreshold.csv").Count());
		}
	}
}