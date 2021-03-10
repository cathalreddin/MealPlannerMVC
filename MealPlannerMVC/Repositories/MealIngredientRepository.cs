using MealPlannerMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Repositories
{
	public class MealIngredientRepository : IMealIngredientRepository
	{
		private readonly AppDbContext _appDbContext;

		public MealIngredientRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public void Add(MealIngredient mealIngredient)
		{
			_appDbContext.Add(mealIngredient);
			_appDbContext.SaveChanges();
		}

		public void Delete(MealIngredient mealIngredient)
		{
			_appDbContext.Remove(mealIngredient);
			_appDbContext.SaveChanges();
		}

		public MealIngredient GetIngredientForMeal(int MealId, int IngredientId)
		{
			var mealIngredient = _appDbContext.MealIngredients
				.Where(x => x.MealId == MealId && x.IngredientId == IngredientId)
				.FirstOrDefault();
			return mealIngredient;
		}

		public IEnumerable<MealIngredient> GetIngredientsForMeal(int MealId)
		{
			var mealIngredients = _appDbContext.MealIngredients.Where(x => x.MealId == MealId)
				.Include(x => x.Ingredient)
				.ThenInclude(y=> y.Item)
				.ToList();
			return mealIngredients;
		}

		public MealIngredient GetMealFromIngredient(int IngredientId)
		{
			var mealIngredient = _appDbContext.MealIngredients
				.Where(x => x.IngredientId == IngredientId)
				.FirstOrDefault();
			return mealIngredient;
		}

		public IEnumerable<MealIngredient> GetMealIngredients()
		{
			return _appDbContext.MealIngredients.ToList();
		}
	}
}
