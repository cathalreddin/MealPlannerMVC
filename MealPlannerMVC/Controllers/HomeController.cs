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
		private readonly IItemRepository _itemRepository;

		public HomeController(ILogger<HomeController> logger, IMealRepository mealRepository,
			IIngredientRepository ingredientsRepository, IItemRepository itemRepository)
		{
			_logger = logger;
			_mealRepository = mealRepository;
			_ingredientsRepository = ingredientsRepository;
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
			//List<Ingredient> x = (List<Ingredient>)_ingredientsRepository.GetIngredientsForMeal(model.Day1Meal1);
			//List<Ingredient> y = (List<Ingredient>)_ingredientsRepository.GetIngredientsForMeal(model.Day1Meal2);
			//x.AddRange(y);
			//var shoppingList = new List<Ingredient>();

			////foreach (var item in x)
			////{
			////	if (item.Id)
			////	{
			////		itemx.Measure += itemy.Measure;
			////	}
			////	else
			////	{
			////		z.Add(itemy);
			////	}
			////}
			

			//model.ShoppingList = x;
			//foreach (var item in model.ShoppingList)
			//{
			//	item.Item.Name = _itemRepository.GetItem(item.ItemId).Name;
			//}
			//model.Meals = _mealRepository.GetMeals();
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
