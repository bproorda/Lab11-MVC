using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_11_MVC.Models
{
    public class TimesPerson
    {
		public int StartYear { get; set; }
		public int EndYear { get; set; }
		public int Year { get; set; }
		public string Honor { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public int BirthYear { get; set; }
		public int DeathYear { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public string Context { get; set; }

		public List<TimesPerson> GetTimesPeople()
		{
			string[] people = File.ReadAllLines("Data/personOfTheYear.csv");

			return people
				.Skip(1)
				.Select(personLine => personLine.Split(","))
				.Select(personCell => new TimesPerson()
				{
					Year = int.Parse(personCell[0]),
					Honor = personCell[1],
					Name = personCell[2],
					Country = personCell[3],
					BirthYear = int.Parse(personCell[4]),
					DeathYear = int.Parse(personCell[5]),
					Title = personCell[6],
					Category = personCell[7],
					Context = personCell[8],
				}).ToList();
		}


	}
}
