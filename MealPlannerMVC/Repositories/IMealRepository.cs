using MealPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Repositories
{
	public interface IMealRepository
	{
		IEnumerable<Meal> GetMeals();
		void Add(Meal item);
		Meal GetMeal(int Id);
	}
}
