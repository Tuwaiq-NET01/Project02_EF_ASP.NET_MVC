using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class seedingCoffee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coffee",
                columns: new[] { "Id", "CoffeeCategoryId", "Description", "Image", "Name", "OrderId", "Price" },
                values: new object[] { 1, 1, "the V60 is one of specialty coffee’s favourite brewing methods. Within 3 minutes, you can brew an incredibly tasty coffee.", "/img/V60.jpeg", "V60", null, 18f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
