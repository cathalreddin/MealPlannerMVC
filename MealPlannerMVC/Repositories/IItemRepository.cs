using MealPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Repositories
{
	public interface IItemRepository
	{
		IEnumerable<Item> GetItems();
		Item GetItem(int Id);
		void Add(Item item);
		void Delete(Item item);
	}
}
