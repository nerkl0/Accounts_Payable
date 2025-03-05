using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_programming
{
	/// <summary>
	/// Designated class for filehandling
	/// </summary>
	public class FileHandling
	{
		/// <summary>
		///	Loads Employee data from the Employee CSV file
		/// </summary>
		/// <param name="filePath">file path of the Employee CSV file</param>
		/// <returns>A list of the contents of Employee file</returns>
		public static List<Employee> LoadEmployee(string filePath)
		{
			var config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				HasHeaderRecord = false
			};
			using var reader = new StreamReader(filePath);
			using var csv = new CsvReader(reader, config);
			{
				var employeeData = new List<Employee>();
				while (csv.Read())
				{
					var record = new Employee
					(
						int.Parse(csv.GetField(0)),
						csv.GetField(1),
						csv.GetField(2),
						double.Parse(csv.GetField(3)),
						csv.GetField(4) == "Y"
					);
					employeeData.Add(record);
				}
				return [.. employeeData];
			}	
		}

		/// <summary>
		/// Tailored to load the threshold data from the respective csv files
		/// </summary>
		/// <param name="filePath">path of the requested csv file</param>
		/// <returns>a list of the file data</returns>
		public static List<ThresholdCalculator> LoadTaxData(string filePath)
		{
			var config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				HasHeaderRecord = false
			};
			using var reader = new StreamReader(filePath);
			using var csv = new CsvReader(reader, config);
			{
				var taxData = new List<ThresholdCalculator>();
				while (csv.Read())
				{
					var data = new ThresholdCalculator
					(
						double.Parse(csv.GetField(0)),
						double.Parse(csv.GetField(1)),
						double.Parse(csv.GetField(2)),
						double.Parse(csv.GetField(3))
					);
					taxData.Add(data);
				}
				return [.. taxData];
			}
		}

		/// <summary>
		/// Saves the employee pay summary to a csv file 
		/// </summary>
		/// <param name="empData">a list of the data to parse</param>
		public static void Save(List<string> empData)
		{
			string empID = empData[2];
			string employeeName = $"{empData[0]} {empData[1]}";

			string filePath = $"../../../Pay-{empID}-{employeeName}-{DateTime.Now.Ticks}.csv";

			if (File.Exists(filePath))
			{
				MessageBox.Show("Employee Payslip already generated");
			}
			else
			{
				var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
				{
					HasHeaderRecord = false
				};

				using var writer = new StreamWriter(filePath);
				using var csv = new CsvWriter(writer, csvConfig);

				foreach (var field in empData.Skip(2))
				{
					csv.WriteField(field);
				}
				MessageBox.Show("Payment Summary Downloaded");
			}
		}
	}
}
