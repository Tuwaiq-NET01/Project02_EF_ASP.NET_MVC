using Microsoft.EntityFrameworkCore.Migrations;

namespace TripWebsite.Migrations
{
    public partial class SeedingTourists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tourists",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "afra@gmail.com", "Afra saleh", 540000000 },
                    { 2, "yara@gmail.com", "Yara abdulaziz", 561111000 },
                    { 3, "maram@gmail.com", "Maram hassan", 540003333 },
                    { 4, "duaa@gmail.com", "duaa abdullah", 555000000 },
                    { 5, "manar@gmail.com", "manar abdullah", 54666669 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tourists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tourists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tourists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tourists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tourists",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
