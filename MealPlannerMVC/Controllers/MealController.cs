using MealPlannerMVC.Models;
using MealPlannerMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Controllers
{
	public class MealController : Controller
	{
		private readonly IMealRepository _mealRepository;
        private readonly IMealIngredientRepository _mealIngredientRepository;

        public MealController(IMealRepository mealRepository, IMealIngredientRepository mealIngredientRepository)
		{
			_mealRepository = mealRepository;
            _mealIngredientRepository = mealIngredientRepository;
        }
		public IActionResult Index()
		{
			var model = _mealRepository.GetMeals();
			return View(model);
		}
		public IActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Add(Meal model)
		{
			_mealRepository.Add(model);
			return RedirectToAction("Index");
		}
		public IActionResult Edit(int id)
		{
			var model = _mealRepository.GetMeal(id);
			return View(model);
		}
		[HttpPost]
		public IActionResult Edit(Meal model)
		{
			_mealRepository.Edit(model);
			return RedirectToAction("Index");
		}
		public IActionResult Copy(int id)
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
			return RedirectToAction("Index");
		}
	}
}
