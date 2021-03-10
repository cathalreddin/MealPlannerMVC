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
		int Add(Meal meal);
		int Edit(Meal meal);
		Meal GetMeal(int Id);

	}
}
