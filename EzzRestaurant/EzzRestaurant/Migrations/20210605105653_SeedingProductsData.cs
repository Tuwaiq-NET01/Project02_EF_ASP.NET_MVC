using Microsoft.EntityFrameworkCore.Migrations;

namespace EzzRestaurant.Migrations
{
    public partial class SeedingProductsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name", "Price", "img" },
                values: new object[,]
                {
                    { 1, 1, "Steak", 100.0, "https://images.pexels.com/photos/3535395/pexels-photo-3535395.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
                    { 2, 1, "Pizza", 16.0, "https://images.pexels.com/photos/825661/pexels-photo-825661.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
                    { 3, 1, "spaghetti", 42.0, "https://images.pexels.com/photos/41320/beef-cheese-cuisine-delicious-41320.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500" },
                    { 4, 1, "pasta", 34.0, "https://images.pexels.com/photos/2703468/pexels-photo-2703468.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500" },
                    { 5, 2, "Orange", 14.0, "https://images.pexels.com/photos/1002778/pexels-photo-1002778.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
                    { 6, 2, "Mango", 14.0, "https://images.pexels.com/photos/4023132/pexels-photo-4023132.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" },
                    { 7, 3, "Entrees one", 21.0, "https://images.pexels.com/photos/4669304/pexels-photo-4669304.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500" },
                    { 8, 4, "Flafel", 21.0, "https://images.pexels.com/photos/6275118/pexels-photo-6275118.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
