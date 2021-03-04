using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlannerMVC.Migrations
{
    public partial class CreateRelationships6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealDay_Days_DayId",
                table: "MealDay");

            migrationBuilder.DropForeignKey(
                name: "FK_MealDay_Meals_MealId",
                table: "MealDay");

            migrationBuilder.DropForeignKey(
                name: "FK_MealIngredient_Ingredients_IngredientId",
                table: "MealIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_MealIngredient_Meals_MealId",
                table: "MealIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealIngredient",
                table: "MealIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealDay",
                table: "MealDay");

            migrationBuilder.RenameTable(
                name: "MealIngredient",
                newName: "MealIngredients");

            migrationBuilder.RenameTable(
                name: "MealDay",
                newName: "MealDays");

            migrationBuilder.RenameIndex(
                name: "IX_MealIngredient_MealId",
                table: "MealIngredients",
                newName: "IX_MealIngredients_MealId");

            migrationBuilder.RenameIndex(
                name: "IX_MealDay_MealId",
                table: "MealDays",
                newName: "IX_MealDays_MealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealIngredients",
                table: "MealIngredients",
                columns: new[] { "IngredientId", "MealId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealDays",
                table: "MealDays",
                columns: new[] { "DayId", "MealId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MealDays_Days_DayId",
                table: "MealDays",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealDays_Meals_MealId",
                table: "MealDays",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealIngredients_Ingredients_IngredientId",
                table: "MealIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealIngredients_Meals_MealId",
                table: "MealIngredients",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealDays_Days_DayId",
                table: "MealDays");

            migrationBuilder.DropForeignKey(
                name: "FK_MealDays_Meals_MealId",
                table: "MealDays");

            migrationBuilder.DropForeignKey(
                name: "FK_MealIngredients_Ingredients_IngredientId",
                table: "MealIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_MealIngredients_Meals_MealId",
                table: "MealIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealIngredients",
                table: "MealIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealDays",
                table: "MealDays");

            migrationBuilder.RenameTable(
                name: "MealIngredients",
                newName: "MealIngredient");

            migrationBuilder.RenameTable(
                name: "MealDays",
                newName: "MealDay");

            migrationBuilder.RenameIndex(
                name: "IX_MealIngredients_MealId",
                table: "MealIngredient",
                newName: "IX_MealIngredient_MealId");

            migrationBuilder.RenameIndex(
                name: "IX_MealDays_MealId",
                table: "MealDay",
                newName: "IX_MealDay_MealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealIngredient",
                table: "MealIngredient",
                columns: new[] { "IngredientId", "MealId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealDay",
                table: "MealDay",
                columns: new[] { "DayId", "MealId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MealDay_Days_DayId",
                table: "MealDay",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealDay_Meals_MealId",
                table: "MealDay",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealIngredient_Ingredients_IngredientId",
                table: "MealIngredient",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealIngredient_Meals_MealId",
                table: "MealIngredient",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
