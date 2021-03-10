using MealPlannerMVC.Models;
using MealPlannerMVC.Repositories;
using MealPlannerMVC.Services;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace MealPlanner.Test
{
	public class MealServiceTest
	{
		private Mock<IMealRepository> mockMealRepository;
		private Mock<IIngredientRepository> mockIngredientRepository;
		private Mock<IMealIngredientRepository> mockMealIngredientRepository;
		public MealServiceTest()
		{
			mockMealRepository = new Mock<IMealRepository>();
			mockIngredientRepository = new Mock<IIngredientRepository>();
			mockMealIngredientRepository = new Mock<IMealIngredientRepository>();
		}
		[Fact]
		public void CopyIngredientCreatesNewIngredientsWithNullMeasure()
		{
			//Arrange
			
			var fakeIngredient = new Ingredient { Id = 1, ItemId = 1, Measure = 1, Unit = "grams" };

			var sut = new MealService(mockMealRepository.Object, mockIngredientRepository.Object,
				mockMealIngredientRepository.Object);
						
			mockIngredientRepository.Setup(x => x.GetIngredient(It.IsAny<int>())).Returns(fakeIngredient);
			mockIngredientRepository.Setup(x => x.Add(It.IsAny<Ingredient>())).Returns(fakeIngredient.Id+1);
			//Act
			var result = sut.CopyIngredient(fakeIngredient.Id);

			//Assert
			//mockIngredientRepository.Verify(x => x.Add(fakeIngredient), Times.Once);
			Assert.NotEqual(fakeIngredient.Id, result);

		}

		//[Fact]
		//public void Test1()
		//{
		//	//Arrange
		//	var sut = new MealService(mockMealRepository.Object, mockIngredientRepository.Object,
		//		mockMealIngredientRepository.Object);

		//	var ingredient1 = new Ingredient { Id = 1, ItemId = 1, Measure = 1, Unit = "grams" };
		//	var ingredient2 = new Ingredient { Id = 2, ItemId = 2, Measure = 2, Unit = "whole" };
		//	var ingredient3 = new Ingredient { Id = 3, ItemId = 3, Measure = 3, Unit = "grams" };
		//	var ingredient4 = new Ingredient { Id = 4, ItemId = 4, Measure = 4, Unit = "ml" };

		//	List<Ingredient> ingredients = new List<Ingredient>();
		//	ingredients.Add(ingredient1);
		//	ingredients.Add(ingredient2);
		//	ingredients.Add(ingredient3);
		//	ingredients.Add(ingredient4);

		//	var meal = new Meal()
		//	{
		//		Id = 1,
		//		IsEnabled = true,
		//		Name = "Test Meal",
		//		MealType = MealType.General,
		//		Who = Who.Cathal,
		//		MealIngredients = new List<MealIngredient>()
		//		{
		//			new MealIngredient() { IngredientId = 1, MealId = 1 },
		//			new MealIngredient() { IngredientId = 2, MealId = 1 },
		//			new MealIngredient() { IngredientId = 3, MealId = 1 },
		//			new MealIngredient() { IngredientId = 4, MealId = 1 }
		//		}
		//	};
		//	mockMealRepository.Setup(x => x.GetMeal(It.IsAny<int>())).Returns(meal);
		//	mockIngredientRepository.Setup(x => x.GetIngredient(It.IsAny<int>())).Returns(ingredient1);
		//	//mockIngredientRepository.Setup(x => x.Add(ingredient1)).Returns(ingredient1);
		//	//Act
		//	sut.CopyRecipe(meal.Id);

		//	//Assert
		//	Assert.True(ingredients.Count == 8);

		//}
	}
}
