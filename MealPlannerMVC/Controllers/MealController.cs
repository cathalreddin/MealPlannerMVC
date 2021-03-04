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

		public MealController(IMealRepository mealRepository)
		{
			_mealRepository = mealRepository;
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
	}
}
