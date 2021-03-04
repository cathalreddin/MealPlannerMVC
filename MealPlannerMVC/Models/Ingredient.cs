using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Models
{
	public class Ingredient
	{
		public Ingredient()
		{
			MealIngredients = new List<MealIngredient>();
		}
		public int Id { get; set; }
		public double Measure { get; set; }
		public string Unit { get; set; }
		public List<MealIngredient> MealIngredients { get; set; }

		public int ItemId { get; set; }
		public virtual Item Item { get; set; }
	}
}
