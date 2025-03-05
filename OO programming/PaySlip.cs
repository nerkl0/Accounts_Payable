using Accessibility;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_programming
{
	/// <summary>
	/// Class to assist with the generation of the payslip with all relevant data
	/// </summary>
	public class PaySlip
	{
		private int _weekNumber;
		private string _todayDate;
		private string _taxThreshold;
		private double _grossPay;
		private double _superPaid;
		private double _taxPaid;
		private double _netPay;
        public Employee Emp { get; set; }
        public double SubmittedHours { get; set; }

		/// <summary>
		/// Constructor storing the employee payslip summary. Generates a random week number, and today's date. 
		/// tax threshold returns a Yes or No string for better readability in the text box
		/// invokes the PayCalculator class to store the pay summary details before sending to the form
		/// </summary>
		/// <param name="emp">Employee that was selected for pay generation</param>
		/// <param name="submittedHours">the hours that were submitted for that employee</param>
		public PaySlip(Employee emp, double submittedHours)
        {
			Emp = emp;
			SubmittedHours = submittedHours;
			Random rnd = new Random();
			_weekNumber = rnd.Next(1, 53);
			_todayDate = DateTime.Today.ToString("dd-MMM-yyyy");
			_taxThreshold = Emp.TaxFreeThreshold ? "Yes" : "No";

			PayCalculator paySummary = new PayCalculator(Emp, SubmittedHours);
			(double grossPay, double super, double taxPaid, double net) = paySummary.GeneratePaySummary();
			_grossPay = grossPay;
			_superPaid = super;
			_taxPaid = taxPaid;
			_netPay = net;
		}

		/// <summary>
		/// Stores the data generated to assist in saving to the csv file
		/// </summary>
		/// <returns>List of generated data</returns>
		public List<string> SaveInformation()
		{
			List<string> values =
			[
				$"{Emp.FirstName}",
				$"{Emp.LastName}",
				$"{Emp.Id}",
				$"{SubmittedHours}",
				$"{Emp.Wage}",
				$"{_taxThreshold[0]}",
				$"{_grossPay}",
				$"{_taxPaid}",
				$"{_netPay}",
				$"{_superPaid}",
			];

			return [.. values];
		}

		/// <summary>
		/// Overrides the ToString method to return a formatted pay summary for the text box
		/// </summary>
		/// <returns>formatted pay summary</returns>
		public override string ToString()
		{
			return $"Week No. {_weekNumber}   |   Date: {_todayDate}\r\n" +
				"-------------------------------------\r\n" +
				$"Employee ID:     {Emp.Id,6}\r\n" +
				$"Employee Name:   {Emp.FirstName,2} {Emp.LastName}\r\n" +
				$"Hours Worked:    {SubmittedHours,5}\r\n" +
				$"Tax Threshold:   {_taxThreshold,8}\r\n" +
				"\r\n\r\n" +
				$"Gross Pay: {_grossPay,18:C2}\r\n" +
				$"Superannuation: {_superPaid,6:C2}\r\n" +
				$"Tax Paid: {_taxPaid,20:C2}\r\n" +
				$"Net Pay: {_netPay,21:C2}\r\n";
		}
	}
}
