using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Models
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public string Unit { get; set; }
        public string Category { get; set; }
	}
}
