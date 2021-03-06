﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlannerMVC.Models
{
	public class Meal
	{
		public Meal()
		{
			MealIngredients = new List<MealIngredient>();
			MealDays = new List<MealDay>();
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public MealType MealType { get; set; }
		public Who Who { get; set; }
		public List<MealIngredient> MealIngredients { get; set; }
		public List<MealDay> MealDays { get; set; }
        public bool IsEnabled { get; set; }

    }
	public enum Who
	{
		Cathal,
		Yasmin,
		Kids
	}
	public enum MealType
	{
		General,
		Refuel
	}
}
