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
		private readonly IIngredientRepository _ingredientRepository;
		private readonly IMealIngredientRepository _mealIngredientRepository;

		public MealService(IMealRepository mealRepository, IIngredientRepository ingredientRepository, IMealIngredientRepository mealIngredientRepository)
		{
			_mealRepository = mealRepository;
			_ingredientRepository = ingredientRepository;
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
				//copy ingredient with meaure = null
				int newIngredientId = CopyIngredient(item.IngredientId);

				var newIngredient = new MealIngredient()
				{
					IngredientId = newIngredientId,
					MealId = newid
				};
				_mealIngredientRepository.Add(newIngredient);
			}
		}

		public int CopyIngredient(int ingredientId)
		{
			var model = _ingredientRepository.GetIngredient(ingredientId);
			var newIngredient = new Ingredient()
			{
				ItemId = model.ItemId,
				Unit = model.Unit,
				Measure = null
			};

			int newid = _ingredientRepository.Add(newIngredient);
			return newid;
		}
	}
}
