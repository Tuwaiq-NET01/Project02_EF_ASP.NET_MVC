using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class r3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SweetAndFood_SweetAndFoodCategory_SweetAndFoodCategoryId",
                table: "SweetAndFood");

            migrationBuilder.DropIndex(
                name: "IX_SweetAndFood_SweetAndFoodCategoryId",
                table: "SweetAndFood");

            migrationBuilder.DropColumn(
                name: "SweetAndFoodCategoryId",
                table: "SweetAndFood");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SweetAndFoodCategoryId",
                table: "SweetAndFood",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SweetAndFood_SweetAndFoodCategoryId",
                table: "SweetAndFood",
                column: "SweetAndFoodCategoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SweetAndFood_SweetAndFoodCategory_SweetAndFoodCategoryId",
                table: "SweetAndFood",
                column: "SweetAndFoodCategoryId",
                principalTable: "SweetAndFoodCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
