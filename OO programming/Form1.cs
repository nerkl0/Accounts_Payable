using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OO_programming
{
    public partial class Form1 : Form
    {
		/// <summary>
		/// sets up a local employee list variable to store the employee data
		/// and list for saving the generated employee data
		/// </summary>
		List<Employee> employeeData = FileHandling.LoadEmployee("../../../employee.csv");
		List<string> saveEmployeeData = new List<string>();

		public Form1()
        {
            InitializeComponent();
			///lists employee details to the list box
			lstBox.DataSource = employeeData.ToList();
		}

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hoursInput;
			///checks input is a number and that it falls between the correct range
			///if true, will generate employee pay summary & 
			///make the save button visible
            if (double.TryParse(txtBoxHours.Text, out hoursInput))
            {
				if (hoursInput <= 0 || hoursInput > 40)
				{
					MessageBox.Show("Hours worked must be greater than 0 and not exceed 40");
				}
				else
				{ 
					Employee employee = employeeData[lstBox.SelectedIndex];
					PaySlip generatePayslip = new PaySlip(employee, hoursInput);
					saveEmployeeData = generatePayslip.SaveInformation(); //saves the data to a list so can be accessed from outside this function.

					txtBoxPaySummary.Text = generatePayslip.ToString(); 
					btnSave.Visible = true;
				}
			}
            else
                MessageBox.Show("Please enter a valid number for hours worked.");

		}

		/// <summary>
		/// Saves employee data to a csv file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSave_Click(object sender, EventArgs e)
        {
			FileHandling.Save(saveEmployeeData);
        }
    }
}
