using MealPlannerMVC.Models;
using MealPlannerMVC.Repositories;
using MealPlannerMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Controllers
{
	public class MealIngredientController : Controller
	{
		private readonly IMealIngredientRepository _mealingredientRepository;
		private readonly IIngredientRepository _ingredientRepository;
		private readonly IMealRepository _mealRepository;

		public MealIngredientController(IMealIngredientRepository mealingredientRepository, IIngredientRepository ingredientRepository, IMealRepository mealRepository)
		{
			_mealingredientRepository = mealingredientRepository;
			_ingredientRepository = ingredientRepository;
			_mealRepository = mealRepository;
		}
		public IActionResult Index(int id)
		{
			var model = _mealingredientRepository.GetIngredientsForMeal(id);
			var newModel = new List<MealIngredientViewModel>();
			foreach (var item in model)
			{
				var temp = new MealIngredientViewModel();
				temp.Id = item.Ingredient.Id;
				temp.ItemName = item.Ingredient.Item.Name;
				temp.Measure = item.Ingredient.Measure;
				temp.Unit = item.Ingredient.Unit;
				temp.MealId = id;
				newModel.Add(temp);
			}
			var meal = _mealRepository.GetMeal(id);
			ViewBag.MealName = meal.Name; 
			ViewBag.MealId = meal.Id;
			return View(newModel);
		}
		public IActionResult Add(int Id)
		{
			var meal = _mealRepository.GetMeal(Id);
			var model = new MealIngredientViewModel()
			{
				MealId = Id,
				MealName = meal.Name
			};
			return View(model);
		}
		[HttpPost]
		public IActionResult Add(MealIngredientViewModel model)
		{
			var newModel = new Ingredient();
			newModel.ItemId = model.ItemId;
			newModel.Measure = model.Measure;
			newModel.Unit = model.Unit;
			
			var newId = _ingredientRepository.Add(newModel);
			var newIMModel = new MealIngredient();
			newIMModel.IngredientId = newId;
			newIMModel.MealId = model.MealId;

			
			_mealingredientRepository.Add(newIMModel);
			return RedirectToAction("Index", "MealIngredient", new { id=newIMModel.MealId} );
		}

		[HttpPost]
		public IActionResult Delete(int mealId, int ingredientId)
		{
			var model = _mealingredientRepository.GetIngredientForMeal(mealId, ingredientId);
			_mealingredientRepository.Delete(model);
			return RedirectToAction("Index", "MealIngredient", new { id = mealId });
		}
	}
}
