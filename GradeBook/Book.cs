using System;
using System.Collections.Generic;
namespace Gradebook
{
	public class Book
	{   public  Book(string name)
        {
			grades =new List<double>();
			this.name = name;

		}
		public void Addgrade(double grade)
		{
			grades.Add(grade);
		}

		static List<double> grades;

        internal statistics GetStatistics()
        {
			var result = new statistics();
			var highgrade = double.MinValue;
			var lowgrade = double.MaxValue;

			foreach (var number in grades) {
				lowgrade = Math.Min(number, lowgrade);
				highgrade = Math.Max(number, highgrade);
				result += number;}
			result /= grades.Count;
			Console.WriteLine($"The lowest grade is {lowgrade} ");
			Console.WriteLine($"The high grade is {highgrade}");
			Console.WriteLine($"the Average grade is {result}");

        }

        private string name;
	}
}
