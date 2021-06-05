using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class coffeeSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coffee",
                columns: new[] { "Id", "CoffeeCategoryId", "Description", "Image", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { 1, 1, "the V60 is one of specialty coffee’s favourite brewing methods. Within 3 minutes, you can brew an incredibly tasty coffee.", "/img/V60.jpeg", "V60", null, 18f },
                    { 2, 1, "the Chemex will give you a remarkably clean cup of coffee", "/img/Chemix.jpeg", "Chemix", null, 17f },
                    { 3, 1, "Amazing milky coffie where the milk is more than the coffie", "/img/Latte.jpeg", "Latte", null, 15f },
                    { 4, 1, "Amazing milky coffie where the milk is more than the coffie", "/img/Espresso.jpeg", "Espresso", null, 11f },
                    { 5, 1, "Amazing milky coffie where the coffie is more than the milk", "/img/Cortado.jpeg", "Cortado", null, 14f },
                    { 6, 2, "The best sweet drink available right now ", "/img/Spanish-Latte.jpeg", "Spanish-Latte", null, 16f },
                    { 7, 2, "The 2nd best sweet drink available right now", "/img/Honey-Latte.jpeg", "Honey-Latte", null, 16f },
                    { 8, 2, "The daily favourite drink ", "/img/ColdPro.jpeg", "ColdPro", null, 21f },
                    { 9, 2, "beautifully assembled summer drink where the strawberry is the main ingrediant", "/img/Strawberry-Moheto.jpeg", "Strawberry-Moheto", null, 15f },
                    { 10, 2, "beautifully assembled summer drink where the lemon is the main ingrediant", "/img/Lemon-Moheto.jpeg", "Lemon-Moheto", null, 15f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Coffee",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
