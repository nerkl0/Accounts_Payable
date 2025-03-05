using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_programming
{
	public class NumberOutsideOfRange : Exception
	{
        /// <summary>
        /// Returns exception for CalcTax in the Threshold Calculator if 
        /// the file values don't align within the if statement
        /// </summary>
        public NumberOutsideOfRange()
        {
            MessageBox.Show("Number falls outside of file range");
        }
    }
}
