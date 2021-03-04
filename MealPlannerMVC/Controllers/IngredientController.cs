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

		public IngredientController(IIngredientRepository ingredientRepository)
		{
			_ingredientRepository = ingredientRepository;
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
	}
}
