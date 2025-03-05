using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OO_programming
{
	/// <summary>
	/// Class for storing calculations for generating pay summary
	/// net, gross, tax, super
	/// </summary>
	public class PayCalculator
	{	
		/// field storing the current 2023 - 2024 Australian Super rate
		private double _superRate = 0.11;
		private double _hourlyRate;
		public Employee Emp { get; set; }
		public double HoursWorked { get; set; }

		/// <summary>
		/// Set up of PayCalculator Constructor 
		/// </summary>
		/// <param name="emp">assigns the employee information</param>
		/// <param name="hours">assigns the hours that were input on the form</param>
        public PayCalculator(Employee emp, double hours)
        {
			Emp = emp; 
			HoursWorked = hours;
			_hourlyRate = emp.Wage;
        }

        private double CalculateGross()
		{
			return _hourlyRate * HoursWorked;
		}

		private double CalculateSuper()
		{
			return Math.Round(CalculateGross() * _superRate, 2);
		}

		/// <summary>
		/// If the boolean value passed through is yes, the CalculateTax function will 
		/// read and return the tax rates for employees claiming the tax free threshold.
		/// If false, returns rates for employees not claiming the threshold
		/// </summary>
		/// <param name="threshold">Boolean value based on the employees threshold claim</param>
		/// <returns>calculation for correct employeetax</returns>
		private double CalculateTax(bool threshold)
		{
			double wholeTaxableDollars = Math.Floor(CalculateGross()) + .99;
			
			if (threshold)
			{
				return ThresholdCalculator.CalcTax("../../../taxrate-withthreshold.csv", wholeTaxableDollars);
			}
			else
			{
				return ThresholdCalculator.CalcTax("../../../taxrate-nothreshold.csv", wholeTaxableDollars);
			}
		}

		/// <summary>
		/// Public method to return pay summary for an employee
		/// </summary>
		/// <returns>tuple for the gross pay, tax paid, net pay and super contribution</returns>
		public (double,double,double,double) GeneratePaySummary()
		{			
			double grossPay = Math.Round(CalculateGross(),2);
			double taxPaid = Math.Round(CalculateTax(Emp.TaxFreeThreshold),2);
			double net = Math.Round(grossPay - taxPaid,2);

			return (grossPay, CalculateSuper(), taxPaid, net);
		}
	}
}