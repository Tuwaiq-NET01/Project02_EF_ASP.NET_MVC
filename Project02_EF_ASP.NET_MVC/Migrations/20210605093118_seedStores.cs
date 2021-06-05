using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class seedStores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 1, "Jeddah", "Store 1" });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 2, "Riyadh", "Store 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[,]
                {
                    { 1, "Audi", "1", null, "Passenger Van", "grey" },
                    { 2, "Chrysler", "2", null, "Passenger Van", "teal" },
                    { 3, "Maserati", "El Camino", null, "Sedan", "lavender" },
                    { 4, "Porsche", "Model T", null, "Sedan", "yellow" },
                    { 5, "Jaguar", "Challenger", null, "Passenger Van", "fuchsia" },
                    { 6, "Honda", "Explorer", null, "Passenger Van", "violet" },
                    { 7, "Aston Martin", "Focus", null, "Passenger Van", "ivory" },
                    { 8, "Toyota", "Spyder", null, "Sedan", "salmon" },
                    { 9, "Hyundai", "Countach", null, "Convertible", "tan" },
                    { 10, "BMW", "Impala", null, "Passenger Van", "white" }
                });
        }
    }
}
