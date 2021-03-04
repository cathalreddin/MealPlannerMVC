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
	public class ItemController : Controller
	{
		public IItemRepository _itemRepository { get; }

		public ItemController(IItemRepository itemRepository)
		{
			_itemRepository = itemRepository;
		}
		public IActionResult Index()
		{
			var model = _itemRepository.GetItems();
			return View(model);
		}
		public IActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Add(Item model)
		{
			_itemRepository.Add(model);
			return RedirectToAction("Index");
		}
		[HttpPost]
		public IActionResult Delete(int id)
		{
			var model = _itemRepository.GetItem(id);
			_itemRepository.Delete(model);
			return RedirectToAction("Index");
		}
	}
}
