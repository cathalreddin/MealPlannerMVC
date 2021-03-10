using MealPlannerMVC.Models;
using MealPlannerMVC.Repositories;
using MealPlannerMVC.Services;
using MealPlannerMVC.ViewModels;
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
        private readonly IMealService _mealService;

        public MealController(IMealRepository mealRepository, IMealService mealService)
		{
			_mealRepository = mealRepository;
			_mealService = mealService;
        }
		public IActionResult Index()
		{
			var model = _mealRepository.GetMeals();
			var ViewModelList = new List<MealViewModel>();
			foreach (var meal in model)
			{
				var viewModel = new MealViewModel();
				viewModel.Id = meal.Id;
				viewModel.MealType = meal.MealType;
				viewModel.Name = meal.Name;
				viewModel.Who = meal.Who;
				viewModel.IsEnabled = meal.IsEnabled;
				ViewModelList.Add(viewModel);
			}
			return View(ViewModelList);
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
			_mealService.CopyRecipe(id);
			return RedirectToAction("Index");
		}
	}
}
