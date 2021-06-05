using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class seedingSFC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SweetAndFoodCategory",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Sweet" });

            migrationBuilder.InsertData(
                table: "SweetAndFoodCategory",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Food" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SweetAndFoodCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SweetAndFoodCategory",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
