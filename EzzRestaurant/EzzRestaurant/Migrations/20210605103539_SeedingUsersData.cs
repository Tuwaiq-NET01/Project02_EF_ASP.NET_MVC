using Microsoft.EntityFrameworkCore.Migrations;

namespace EzzRestaurant.Migrations
{
    public partial class SeedingUsersData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Fname", "Lname", "PhoneNumber" },
                values: new object[] { 1, "1997-5-31", "Abdulaziz", "Almohammadi", 582215215 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Fname", "Lname", "PhoneNumber" },
                values: new object[] { 2, "1992-3-03", "Hussain", "Alghamdi", 555488485 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
