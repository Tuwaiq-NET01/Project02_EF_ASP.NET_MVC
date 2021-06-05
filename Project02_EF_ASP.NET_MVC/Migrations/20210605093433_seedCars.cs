using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class seedCars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[,]
                {
                    { 1, "Ford", "V90", 2, "Coupe", "silver" },
                    { 2, "Ferrari", "Silverado", 2, "SUV", "indigo" },
                    { 3, "BMW", "A8", 1, "SUV", "orange" },
                    { 4, "Lamborghini", "Beetle", 1, "Coupe", "magenta" },
                    { 5, "Tesla", "Land Cruiser", 1, "Hatchback", "grey" },
                    { 6, "Dodge", "Challenger", 1, "Coupe", "fuchsia" },
                    { 7, "BMW", "CTS", 2, "Cargo Van", "lime" },
                    { 8, "Fiat", "Silverado", 1, "Wagon", "black" },
                    { 9, "Toyota", "F-150", 1, "Coupe", "red" },
                    { 10, "Smart", "Mustang", 1, "Passenger Van", "silver" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
