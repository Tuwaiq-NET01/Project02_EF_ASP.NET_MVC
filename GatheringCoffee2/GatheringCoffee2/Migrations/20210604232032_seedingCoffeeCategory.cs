using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class seedingCoffeeCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoffeeCategory",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Hot Coffee" });

            migrationBuilder.InsertData(
                table: "CoffeeCategory",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Cold Coffee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoffeeCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoffeeCategory",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
