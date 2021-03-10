using MealPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.ViewModels
{
	public class MealViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public MealType MealType { get; set; }
		public Who Who { get; set; }
		public bool IsEnabled { get; set; }
		public bool MeasuresAreComplete { get; set; }
	}
}
