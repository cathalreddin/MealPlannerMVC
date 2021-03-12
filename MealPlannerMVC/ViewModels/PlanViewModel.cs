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
		public int Meal7 { get; set; }
		public int Meal7B { get; set; }
		public int Meal8 { get; set; }
		public int Meal8B { get; set; }

		public int Meal9 { get; set; }
		public int Meal9B { get; set; }
		public int Meal10 { get; set; }
		public int Meal10B { get; set; }

		public int Meal11 { get; set; }
		public int Meal11B { get; set; }
		public int Meal12 { get; set; }
		public int Meal12B { get; set; }
		public int Meal13 { get; set; }
		public int Meal13B { get; set; }
		public int Meal14 { get; set; }
		public int Meal14B { get; set; }

		public int Meal15 { get; set; }
		public int Meal15B { get; set; }
		public int Meal16 { get; set; }
		public int Meal16B { get; set; }
		public int Meal17 { get; set; }
		public int Meal17B { get; set; }
		public int Meal18 { get; set; }
		public int Meal18B { get; set; }

		public int Meal19 { get; set; }
		public int Meal19B { get; set; }
		public int Meal20 { get; set; }
		public int Meal20B { get; set; }

		public int Meal21 { get; set; }
		public int Meal21B { get; set; }
		public int Meal22 { get; set; }
		public int Meal22B { get; set; }
		public int Meal23 { get; set; }
		public int Meal23B { get; set; }
		public int Meal24 { get; set; }
		public int Meal24B { get; set; }
		public IEnumerable<Meal> Meals { get; set; }
		public List<Ingredient> ShoppingList { get; set; }
	}
}
