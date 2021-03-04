using MealPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Repositories
{
	public class ItemRepository : IItemRepository
	{
		private readonly AppDbContext _appDbContext;
		public ItemRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}		

		public void Add(Item item)
		{
			_appDbContext.Add(item);
			_appDbContext.SaveChanges();
		}

		public void Delete(Item item)
		{
			_appDbContext.Remove(item);
			_appDbContext.SaveChanges();
		}

		public Item GetItem(int Id)
		{
			return _appDbContext.Items.Where(x => x.Id == Id).FirstOrDefault();
		}

		public IEnumerable<Item> GetItems()
		{
			return _appDbContext.Items.ToList();
		}
	}
}
