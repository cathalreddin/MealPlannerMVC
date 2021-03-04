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

		public IEnumerable<Ingredient> GetIngredients()
		{
			return _appDbContext.Ingredients.ToList();
		}
				
	}
}
