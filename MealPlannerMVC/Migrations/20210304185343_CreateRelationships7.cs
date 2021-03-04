using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlannerMVC.Migrations
{
    public partial class CreateRelationships7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Who",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ItemId",
                table: "Ingredients",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Items_ItemId",
                table: "Ingredients",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Items_ItemId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_ItemId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Who",
                table: "Meals");
        }
    }
}
