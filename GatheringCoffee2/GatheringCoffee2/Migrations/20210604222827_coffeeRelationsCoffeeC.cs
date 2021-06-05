using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class coffeeRelationsCoffeeC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoffeeCategoryId",
                table: "Coffee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Coffee_CoffeeCategoryId",
                table: "Coffee",
                column: "CoffeeCategoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Coffee_CoffeeCategory_CoffeeCategoryId",
                table: "Coffee",
                column: "CoffeeCategoryId",
                principalTable: "CoffeeCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coffee_CoffeeCategory_CoffeeCategoryId",
                table: "Coffee");

            migrationBuilder.DropIndex(
                name: "IX_Coffee_CoffeeCategoryId",
                table: "Coffee");

            migrationBuilder.DropColumn(
                name: "CoffeeCategoryId",
                table: "Coffee");
        }
    }
}
