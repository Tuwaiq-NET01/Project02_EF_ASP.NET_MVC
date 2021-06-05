using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class editCoffeeCategoryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Coffee_CoffeeCategoryId",
                table: "Coffee");

            migrationBuilder.CreateIndex(
                name: "IX_Coffee_CoffeeCategoryId",
                table: "Coffee",
                column: "CoffeeCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Coffee_CoffeeCategoryId",
                table: "Coffee");

            migrationBuilder.CreateIndex(
                name: "IX_Coffee_CoffeeCategoryId",
                table: "Coffee",
                column: "CoffeeCategoryId",
                unique: true);
        }
    }
}
