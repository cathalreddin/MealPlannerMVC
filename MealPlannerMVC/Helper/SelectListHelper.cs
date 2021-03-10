using MealPlannerMVC.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Helper
{
	public class SelectListHelper : ISelectListHelper
	{
		private readonly IItemRepository _itemRepository;
		private readonly IMealRepository _mealRepository;

		public SelectListHelper(IItemRepository itemRepository, IMealRepository mealRepository)
		{
			_itemRepository = itemRepository;
			_mealRepository = mealRepository;
		}
		public IEnumerable<SelectListItem> ListItems()
		{
			return (from p in _itemRepository.GetItems()
					orderby p.Name
					select new SelectListItem()
					{
						Text = $"{p.Name}",
						Value = $"{p.Id}"
					});
		}

		public IEnumerable<SelectListItem> ListMealsForCathal()
		{
			return (from p in _mealRepository.GetMeals()
					where p.Who == Models.Who.Cathal
					orderby p.Name
					select new SelectListItem()
					{
						Text = $"{p.Name}",
						Value = $"{p.Id}"
					});
		}

		public IEnumerable<SelectListItem> ListMealsForYasmin()
		{
			return (from p in _mealRepository.GetMeals()
					where p.Who == Models.Who.Yasmin
					orderby p.Name
					select new SelectListItem()
					{
						Text = $"{p.Name}",
						Value = $"{p.Id}"
					});
		}
	}
}
