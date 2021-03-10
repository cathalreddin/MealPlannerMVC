using MealPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.ViewModels
{
	public class PlanViewModel
	{
		public PlanViewModel()
		{
			ShoppingList = new List<Ingredient>();
		}
		public int Meal1 { get; set; }
		public int Meal1B { get; set; }
		public int Meal2 { get; set; }
		public int Meal2B { get; set; }

		public int Meal3 { get; set; }
		public int Meal3B { get; set; }
		public int Meal4 { get; set; }
		public int Meal4B { get; set; }

		public int Meal5 { get; set; }
		public int Meal5B { get; set; }
		public int Meal6 { get; set; }
		public int Meal6B { get; set; }
		public IEnumerable<Meal> Meals { get; set; }
		public List<Ingredient> ShoppingList { get; set; }
	}
}
