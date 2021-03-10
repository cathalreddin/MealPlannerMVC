using MealPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MealPlannerMVC.Repositories
{
	public class IngredientRepository : IIngredientRepository
	{
		private readonly AppDbContext _appDbContext;
		public IngredientRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		

		public int Add(Ingredient item)
		{
			var entityAdded = _appDbContext.Add(item);
			_appDbContext.SaveChanges();
			return entityAdded.Entity.Id;
		}

        public int Edit(Ingredient item)
        {
			_appDbContext.Update(item);
			_appDbContext.SaveChanges();
			var id = item.Id;
			return id;
		}

        public Ingredient GetIngredient(int id)
		{
			return _appDbContext.Ingredients
				.Where(x=>x.Id == id)
				.Include(y=>y.Item)
				.FirstOrDefault();
		}

		public IEnumerable<Ingredient> GetIngredients()
		{
			return _appDbContext.Ingredients.ToList();
		}
		public void Delete(Ingredient ingredient)
		{
			_appDbContext.Remove(ingredient);
			_appDbContext.SaveChanges();
		}

	}
}
