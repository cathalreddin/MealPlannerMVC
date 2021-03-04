using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Models
{
	public class MealIngredient
	{
		public int MealId { get; set; }
		public int IngredientId { get; set; }
		public Meal Meal { get; set; }
		public Ingredient Ingredient { get; set; }
	}
}
