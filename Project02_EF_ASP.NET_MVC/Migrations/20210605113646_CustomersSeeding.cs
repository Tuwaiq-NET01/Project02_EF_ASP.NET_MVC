using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class CustomersSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 3, "Audi", "Mustang", "Wagon", "fuchsia" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 2, "Lamborghini", "XTS", "Extended Cab Pickup", "black" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 3, "Dodge", "CTS", "Extended Cab Pickup", "olive" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 3, "Aston Martin", "Ranchero", "Cargo Van", "yellow" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Lamborghini", "A4", 2, "Wagon", "white" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { 1, "Mini", "A8", 2, "Convertible", "fuchsia" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 3, "Volkswagen", "Grand Caravan", "Convertible", "purple" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "color" },
                values: new object[] { 1, "Chevrolet", "Model 3", "maroon" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Nissan", "Spyder", 2, "Convertible", "azure" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Audi", "2", 1, "Sedan", "red" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { 2, "Tesla", "Silverado", 2, "SUV", "purple" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryID", "Model", "Type", "color" },
                values: new object[] { 1, "Charger", "Hatchback", "teal" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Manufacturer", "Model", "Type", "color" },
                values: new object[] { "Lamborghini", "Aventador", "Hatchback", "white" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { 3, "BMW", "Ranchero", 1, "Passenger Van", "cyan" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Manufacturer", "Model", "Type", "color" },
                values: new object[] { "Cadillac", "Golf", "Sedan", "sky blue" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Manufacturer", "Model", "Type", "color" },
                values: new object[] { "Ferrari", "2", "Convertible", "blue" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 2, "Aston Martin", "Mustang", "Wagon", "maroon" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Model", "StoreId", "Type", "color" },
                values: new object[] { "Roadster", 1, "Convertible", "indigo" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 1, "Bentley", "Golf", "Cargo Van", "black" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 3, "Ford", "CX-9", "SUV", "yellow" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Kia", "Golf", 2, "Minivan", "orchid" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Bugatti", "Durango", 1, "Passenger Van", "yellow" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Maserati", "Element", 1, "Convertible", "green" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { 1, "Lamborghini", "Escalade", 1, "Extended Cab Pickup", "azure" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { 1, "Tesla", "Fiesta", 2, "Cargo Van", "lavender" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CarId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 9, 9, "Lenny Cronin", "320.779.2708 x7633" },
                    { 8, 8, "Ethan Ortiz", "(495) 413-9321" },
                    { 7, 7, "Pascale Schamberger", "449.652.6624 x60230" },
                    { 6, 6, "Dean Kuhn", "908.819.5933" },
                    { 5, 5, "Emely Terry", "(354) 719-4232 x423" },
                    { 4, 4, "Colten Reichel", "647.537.8367 x348" },
                    { 3, 3, "Filiberto McCullough", "1-917-835-3747 x8043" },
                    { 2, 2, "Wilhelm Mann", "703.368.5635" },
                    { 10, 10, "Roy Walsh", "562-745-0841 x0294" },
                    { 1, 1, "Kim Turcotte", "(320) 996-3683" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 2, "Land Rover", "CX-9", "Extended Cab Pickup", "white" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 1, "Tesla", "XC90", "Passenger Van", "salmon" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 2, "Volvo", "El Camino", "Convertible", "lavender" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 1, "Mercedes Benz", "V90", "Crew Cab Pickup", "cyan" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Nissan", "Camaro", 1, "Minivan", "maroon" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { 3, "Jaguar", "F-150", 1, "SUV", "teal" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 2, "Chevrolet", "Fortwo", "Wagon", "orange" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "color" },
                values: new object[] { 2, "Toyota", "Durango", "orchid" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Tesla", "PT Cruiser", 1, "Wagon", "violet" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Mercedes Benz", "Civic", 2, "Wagon", "mint green" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { 3, "Audi", "Grand Caravan", 1, "Hatchback", "olive" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryID", "Model", "Type", "color" },
                values: new object[] { 3, "Beetle", "Sedan", "black" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Manufacturer", "Model", "Type", "color" },
                values: new object[] { "Land Rover", "ATS", "Cargo Van", "ivory" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { 1, "Hyundai", "F-150", 2, "SUV", "teal" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Manufacturer", "Model", "Type", "color" },
                values: new object[] { "Bentley", "Focus", "Wagon", "white" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Manufacturer", "Model", "Type", "color" },
                values: new object[] { "Tesla", "Focus", "Extended Cab Pickup", "magenta" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 3, "Audi", "Silverado", "Extended Cab Pickup", "fuchsia" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Model", "StoreId", "Type", "color" },
                values: new object[] { "Prius", 2, "Passenger Van", "blue" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 2, "Hyundai", "1", "Passenger Van", "violet" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "Type", "color" },
                values: new object[] { 1, "Kia", "Countach", "Wagon", "violet" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Volkswagen", "F-150", 1, "Coupe", "blue" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Jeep", "Countach", 2, "Cargo Van", "magenta" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { "Cadillac", "Model S", 2, "Sedan", "yellow" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { 2, "Fiat", "Fiesta", 2, "Convertible", "purple" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryID", "Manufacturer", "Model", "StoreId", "Type", "color" },
                values: new object[] { 2, "Bentley", "Challenger", 1, "Coupe", "red" });
        }
    }
}
