namespace MealPlannerMVC.Models
{
	public class MealDay
	{
		public int MealId { get; set; }
		public int DayId { get; set; }
		public Meal Meal { get; set; }
		public Day Day { get; set; }
	}
}