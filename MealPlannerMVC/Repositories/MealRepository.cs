using MealPlannerMVC.Models;
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

		public void Add(Meal meal)
		{
			_appDbContext.Add(meal);
			_appDbContext.SaveChanges();
		}

		public Meal GetMeal(int Id)
		{
			return _appDbContext.Meals.Where(x => x.Id == Id).FirstOrDefault();
		}

		public IEnumerable<Meal> GetMeals()
		{
			return _appDbContext.Meals
				.ToList();
		}

		
	}
}
