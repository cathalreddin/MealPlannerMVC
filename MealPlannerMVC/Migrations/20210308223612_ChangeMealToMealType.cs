using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlannerMVC.Migrations
{
    public partial class ChangeMealToMealType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Meals",
                newName: "MealType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MealType",
                table: "Meals",
                newName: "Type");
        }
    }
}
