using MealPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Repositories
{
	public interface IMealIngredientRepository
	{
		IEnumerable<MealIngredient> GetMealIngredients();
		IEnumerable<MealIngredient> GetIngredientsForMeal(int MealId);
		MealIngredient GetIngredientForMeal(int MealId, int IngredientId);
		void Add(MealIngredient mealIngredient);
		void Delete(MealIngredient mealIngredient);
	}
}
