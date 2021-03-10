using MealPlannerMVC.Models;
using MealPlannerMVC.Repositories;
using MealPlannerMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IMealRepository _mealRepository;
		private readonly IIngredientRepository _ingredientsRepository;
		private readonly IMealIngredientRepository _mealIngredientsRepository;
		private readonly IItemRepository _itemRepository;

		public HomeController(ILogger<HomeController> logger, IMealRepository mealRepository,
			IIngredientRepository ingredientsRepository, IMealIngredientRepository mealIngredientsRepository, IItemRepository itemRepository)
		{
			_logger = logger;
			_mealRepository = mealRepository;
			_ingredientsRepository = ingredientsRepository;
			_mealIngredientsRepository = mealIngredientsRepository;
			_itemRepository = itemRepository;

		}

		public IActionResult Index()
		{
			var model = new PlanViewModel();
			model.Meals = _mealRepository.GetMeals();
			return View(model);
		}

		[HttpPost]
		public IActionResult Index(PlanViewModel model)
		{
			var mealPlan = new Dictionary<int, int>();
			if (mealPlan.ContainsKey(model.Meal1))
			{
				mealPlan[model.Meal1] += model.Meal1B; 
			}
			else
			{
				mealPlan.Add(model.Meal1, model.Meal1B);
			}

			if (mealPlan.ContainsKey(model.Meal2))
			{
				mealPlan[model.Meal2] += model.Meal2B;
			}
			else
			{
				mealPlan.Add(model.Meal2, model.Meal2B);
			}
			if (mealPlan.ContainsKey(model.Meal3))
			{
				mealPlan[model.Meal3] += model.Meal3B;
			}
			else
			{
				mealPlan.Add(model.Meal3, model.Meal3B);
			}
			if (mealPlan.ContainsKey(model.Meal4))
			{
				mealPlan[model.Meal4] += model.Meal4B;
			}
			else
			{
				mealPlan.Add(model.Meal4, model.Meal4B);
			}
			if (mealPlan.ContainsKey(model.Meal5))
			{
				mealPlan[model.Meal5] += model.Meal5B;
			}
			else
			{
				mealPlan.Add(model.Meal5, model.Meal5B);
			}
			if (mealPlan.ContainsKey(model.Meal6))
			{
				mealPlan[model.Meal6] += model.Meal6B;
			}
			else
			{
				mealPlan.Add(model.Meal6, model.Meal6B);
			}
			// have <MealID, Quantity>
			// want <IngredientID, Quantity>


			List<Ingredient> shoppingList = new List<Ingredient>();
			foreach (var meal in mealPlan)
			{
				var thisMeal = _mealIngredientsRepository.GetIngredientsForMeal(meal.Key);
				foreach (var item in thisMeal)
				{
					var ingredient = _ingredientsRepository.GetIngredient(item.IngredientId);
					ingredient.Measure *= meal.Value;
					if (shoppingList.Where(x => x.ItemId == ingredient.ItemId).Any())
					{
						var x = shoppingList.Where(x => x.ItemId == ingredient.ItemId).FirstOrDefault();
						x.Measure += ingredient.Measure;
					}
					else
					{
						shoppingList.Add(ingredient);
					}
				}
			}
			model.ShoppingList = shoppingList;
			return View(model);
		}
		public IActionResult ShoppingList(List<Ingredient> model)
		{			
			return View(model);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
