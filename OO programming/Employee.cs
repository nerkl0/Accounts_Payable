using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_programming
{
	/// <summary>
	/// Employee class that holds data on employees
	/// </summary>
	public class Employee
	{
        public int Id{ get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public double Wage { get; set; }
		public bool TaxFreeThreshold { get; set; }

        public Employee(int id, string firstName, string lastName, double wage, bool taxFreeThreshold)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Wage = wage;
			TaxFreeThreshold = taxFreeThreshold;
		}

		/// <summary>
		/// Overides ToString method
		/// </summary>
		/// <returns>formatted string with targeted information</returns>
		public override string ToString()
		{
			return $"{Id}: {FirstName} {LastName}";
		}
	}
}
