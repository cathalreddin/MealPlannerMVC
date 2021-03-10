using MealPlannerMVC.Models;
using MealPlannerMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Controllers
{
	public class IngredientController : Controller
	{
		private readonly IIngredientRepository _ingredientRepository;
		private readonly IMealIngredientRepository _mealIngredientRepository;

		public IngredientController(IIngredientRepository ingredientRepository, IMealIngredientRepository mealIngredientRepository)
		{
			_ingredientRepository = ingredientRepository;
			_mealIngredientRepository = mealIngredientRepository;
		}
		public IActionResult Index()
		{
			var model = _ingredientRepository.GetIngredients();
			return View(model);
		}
		public IActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Add(Ingredient model)
		{
			_ingredientRepository.Add(model);
			return View();
		}
		public IActionResult Edit(int id)
		{
			var model = _ingredientRepository.GetIngredient(id);
			return View(model);
		}
		[HttpPost]
		public IActionResult Edit(Ingredient model)
		{
			_ingredientRepository.Edit(model);
			var meal = _mealIngredientRepository.GetMealFromIngredient(model.Id);	
			return RedirectToAction("Index", "MealIngredient", new { id = meal.MealId });
		}
		[HttpPost]
		public IActionResult Delete(int id)
		{
			var model = _ingredientRepository.GetIngredient(id);
			_ingredientRepository.Delete(model);
			return RedirectToAction("Index");
		}
	}
}
