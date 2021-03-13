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
			var mealPlan = new Dictionary<int, double>();
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
			if (mealPlan.ContainsKey(model.Meal7))
			{
				mealPlan[model.Meal7] += model.Meal7B;
			}
			else
			{
				mealPlan.Add(model.Meal7, model.Meal7B);
			}

			if (mealPlan.ContainsKey(model.Meal8))
			{
				mealPlan[model.Meal8] += model.Meal8B;
			}
			else
			{
				mealPlan.Add(model.Meal8, model.Meal8B);
			}
			if (mealPlan.ContainsKey(model.Meal9))
			{
				mealPlan[model.Meal9] += model.Meal9B;
			}
			else
			{
				mealPlan.Add(model.Meal9, model.Meal9B);
			}
			if (mealPlan.ContainsKey(model.Meal10))
			{
				mealPlan[model.Meal10] += model.Meal10B;
			}
			else
			{
				mealPlan.Add(model.Meal10, model.Meal10B);
			}
			if (mealPlan.ContainsKey(model.Meal11))
			{
				mealPlan[model.Meal11] += model.Meal11B;
			}
			else
			{
				mealPlan.Add(model.Meal11, model.Meal11B);
			}
			if (mealPlan.ContainsKey(model.Meal12))
			{
				mealPlan[model.Meal12] += model.Meal12B;
			}
			else
			{
				mealPlan.Add(model.Meal12, model.Meal12B);
			}
			if (mealPlan.ContainsKey(model.Meal13))
			{
				mealPlan[model.Meal13] += model.Meal13B;
			}
			else
			{
				mealPlan.Add(model.Meal13, model.Meal13B);
			}
			if (mealPlan.ContainsKey(model.Meal14))
			{
				mealPlan[model.Meal14] += model.Meal14B;
			}
			else
			{
				mealPlan.Add(model.Meal14, model.Meal14B);
			}
			if (mealPlan.ContainsKey(model.Meal15))
			{
				mealPlan[model.Meal15] += model.Meal15B;
			}
			else
			{
				mealPlan.Add(model.Meal15, model.Meal15B);
			}
			if (mealPlan.ContainsKey(model.Meal16))
			{
				mealPlan[model.Meal16] += model.Meal16B;
			}
			else
			{
				mealPlan.Add(model.Meal16, model.Meal16B);
			}
			if (mealPlan.ContainsKey(model.Meal17))
			{
				mealPlan[model.Meal17] += model.Meal17B;
			}
			else
			{
				mealPlan.Add(model.Meal17, model.Meal17B);
			}

			if (mealPlan.ContainsKey(model.Meal18))
			{
				mealPlan[model.Meal18] += model.Meal18B;
			}
			else
			{
				mealPlan.Add(model.Meal18, model.Meal18B);
			}
			if (mealPlan.ContainsKey(model.Meal19))
			{
				mealPlan[model.Meal19] += model.Meal19B;
			}
			else
			{
				mealPlan.Add(model.Meal19, model.Meal19B);
			}
			if (mealPlan.ContainsKey(model.Meal20))
			{
				mealPlan[model.Meal20] += model.Meal20B;
			}
			else
			{
				mealPlan.Add(model.Meal20, model.Meal20B);
			}
			if (mealPlan.ContainsKey(model.Meal21))
			{
				mealPlan[model.Meal21] += model.Meal21B;
			}
			else
			{
				mealPlan.Add(model.Meal21, model.Meal21B);
			}
			if (mealPlan.ContainsKey(model.Meal22))
			{
				mealPlan[model.Meal22] += model.Meal22B;
			}
			else
			{
				mealPlan.Add(model.Meal22, model.Meal22B);
			}

			if (mealPlan.ContainsKey(model.Meal23))
			{
				mealPlan[model.Meal23] += model.Meal23B;
			}
			else
			{
				mealPlan.Add(model.Meal23, model.Meal23B);
			}
			if (mealPlan.ContainsKey(model.Meal24))
			{
				mealPlan[model.Meal24] += model.Meal24B;
			}
			else
			{
				mealPlan.Add(model.Meal24, model.Meal24B);
			}
			// have <MealID, Quantity>
			mealPlan.Remove(0);
			var ingredientPlan = new Dictionary<int, double>();
			foreach (var meal in mealPlan)
			{
				//get ingredient x quantity and return this dict
				var thisMeal = _mealIngredientsRepository.GetIngredientsForMeal(meal.Key);
				foreach (var ingredient in thisMeal)
				{
					if (!ingredientPlan.TryAdd(ingredient.Ingredient.ItemId, Convert.ToDouble(meal.Value*ingredient.Ingredient.Measure)))
					{
						ingredientPlan[ingredient.Ingredient.ItemId] += Convert.ToDouble(meal.Value * ingredient.Ingredient.Measure);
					}
				}
			}
			// want <ItemId, Quantity>
			var shoppingList = new PlanViewModel();
			foreach (var item in ingredientPlan)
			{
				var theItem = _itemRepository.GetItem(item.Key);
				//var ingredientUnit = _itemRepository.GetIngredient(theItem.)
				var i = new Ingredient()
				{
					ItemId = theItem.Id,
					Item = theItem,
					Measure = item.Value,
					//NEED TO GET THE UNIT VALUE**************
					//Unit = theItem.Unit					
				};
				//ingred.Measure = ingredient.Value;
				shoppingList.ShoppingList.Add(i);
			}

			return View(shoppingList);
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
