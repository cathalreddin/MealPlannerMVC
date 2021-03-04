using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.ViewModels
{
	public class MealIngredientViewModel
	{
		public int Id { get; set; }
		public int MealId { get; set; }
		public string MealName { get; set; }
		public double Measure { get; set; }
		public string Unit { get; set; }
		public string ItemName { get; set; }
		public int ItemId { get; set; }
	}
}
