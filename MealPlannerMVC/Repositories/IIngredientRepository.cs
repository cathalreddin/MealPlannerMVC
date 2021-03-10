using MealPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Repositories
{
	public interface IIngredientRepository
	{
		IEnumerable<Ingredient> GetIngredients();
		Ingredient GetIngredient(int id);
		int Add(Ingredient item);
	}
}
