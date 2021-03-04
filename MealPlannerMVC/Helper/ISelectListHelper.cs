using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Helper
{
	public interface ISelectListHelper
	{
		IEnumerable<SelectListItem> ListItems();
		IEnumerable<SelectListItem> ListMealsForYasmin();
		IEnumerable<SelectListItem> ListMealsForCathal();
	}
}
