using MealPlannerMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Repositories
{
	public class MealRepository : IMealRepository
	{
		private readonly AppDbContext _appDbContext;

		public MealRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public int Add(Meal meal)
		{
			_appDbContext.Add(meal); 
			Commit();
			var id = meal.Id;
			return id;
		}

        public int Edit(Meal meal)
        {
			_appDbContext.Update(meal);
			Commit();
			var id = meal.Id;
			return id;
		}
		public void Commit()
        {
			_appDbContext.SaveChanges();
		}

        public Meal GetMeal(int Id)
		{
			return _appDbContext.Meals.Where(x => x.Id == Id)
				.Include(x=>x.MealIngredients)
				.FirstOrDefault();
		}

		public IEnumerable<Meal> GetMeals()
		{
			return _appDbContext.Meals
				.ToList();
		}

		
	}
}
