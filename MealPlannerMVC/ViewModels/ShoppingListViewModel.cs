using MealPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.ViewModels
{
	public class ShoppingListViewModel
	{
		public ShoppingListViewModel()
		{
			Ingredients = new List<Ingredient>();
		}
		public List<Ingredient> Ingredients { get; set; }
	}
}
