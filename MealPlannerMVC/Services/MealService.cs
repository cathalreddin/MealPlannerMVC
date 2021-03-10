using MealPlannerMVC.Models;
using MealPlannerMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Services
{
	public class MealService : IMealService
	{
		private readonly IMealRepository _mealRepository;
		private readonly IMealIngredientRepository _mealIngredientRepository;

		public MealService(IMealRepository mealRepository, IMealIngredientRepository mealIngredientRepository)
		{
			_mealRepository = mealRepository;
			_mealIngredientRepository = mealIngredientRepository;
		}
		public void CopyRecipe(int id)
		{
			var model = _mealRepository.GetMeal(id);

			var newMeal = new Meal()
			{
				Name = model.Name,
				MealType = model.MealType,
				Who = model.Who == Who.Cathal ? Who.Yasmin : Who.Cathal
			};
			int newid = _mealRepository.Add(newMeal);

			foreach (var item in model.MealIngredients)
			{
				var newIngredient = new MealIngredient()
				{
					IngredientId = item.IngredientId,
					MealId = newid
				};
				_mealIngredientRepository.Add(newIngredient);
			}
		}
	}
}
