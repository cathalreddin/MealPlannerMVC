using MealPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.ViewModels
{
	public class PlanViewModel
	{
		public int Day1Meal1 { get; set; }
		public int Day1Meal2 { get; set; }
		public IEnumerable<Meal> Meals { get; set; }
		public List<Ingredient> ShoppingList { get; set; }
	}
}
