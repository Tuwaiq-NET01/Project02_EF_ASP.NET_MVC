using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class CarsSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[,]
                {
                    { 1, 2, "Land Rover", "CX-9", 2, "Extended Cab Pickup", "white" },
                    { 23, 3, "Cadillac", "Model S", 2, "Sedan", "yellow" },
                    { 22, 3, "Jeep", "Countach", 2, "Cargo Van", "magenta" },
                    { 21, 3, "Volkswagen", "F-150", 1, "Coupe", "blue" },
                    { 20, 1, "Kia", "Countach", 2, "Wagon", "violet" },
                    { 19, 2, "Hyundai", "1", 2, "Passenger Van", "violet" },
                    { 18, 3, "Lamborghini", "Prius", 2, "Passenger Van", "blue" },
                    { 17, 3, "Audi", "Silverado", 1, "Extended Cab Pickup", "fuchsia" },
                    { 16, 2, "Tesla", "Focus", 1, "Extended Cab Pickup", "magenta" },
                    { 15, 3, "Bentley", "Focus", 2, "Wagon", "white" },
                    { 14, 1, "Hyundai", "F-150", 2, "SUV", "teal" },
                    { 24, 2, "Fiat", "Fiesta", 2, "Convertible", "purple" },
                    { 13, 2, "Land Rover", "ATS", 2, "Cargo Van", "ivory" },
                    { 11, 3, "Audi", "Grand Caravan", 1, "Hatchback", "olive" },
                    { 10, 1, "Mercedes Benz", "Civic", 2, "Wagon", "mint green" },
                    { 9, 2, "Tesla", "PT Cruiser", 1, "Wagon", "violet" },
                    { 8, 2, "Toyota", "Durango", 1, "SUV", "orchid" },
                    { 7, 2, "Chevrolet", "Fortwo", 2, "Wagon", "orange" },
                    { 6, 3, "Jaguar", "F-150", 1, "SUV", "teal" },
                    { 5, 1, "Nissan", "Camaro", 1, "Minivan", "maroon" },
                    { 4, 1, "Mercedes Benz", "V90", 1, "Crew Cab Pickup", "cyan" },
                    { 3, 2, "Volvo", "El Camino", 2, "Convertible", "lavender" },
                    { 2, 1, "Tesla", "XC90", 1, "Passenger Van", "salmon" },
                    { 12, 3, "Ford", "Beetle", 2, "Sedan", "black" },
                    { 25, 2, "Bentley", "Challenger", 1, "Coupe", "red" }
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

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
