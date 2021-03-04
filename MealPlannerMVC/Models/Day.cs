using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Models
{
	public class Day
	{
		public Day()
		{
			MealDays = new List<MealDay>();
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public List<MealDay> MealDays { get; set; }
	}
}
