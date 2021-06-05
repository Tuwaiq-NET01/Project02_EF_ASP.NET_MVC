using Microsoft.EntityFrameworkCore.Migrations;

namespace Compound.Migrations
{
    public partial class SeedingUserEventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users_Events",
                columns: new[] { "Id", "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 1, 2 },
                    { 3, 3, 3 },
                    { 4, 5, 4 },
                    { 5, 4, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users_Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users_Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users_Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users_Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users_Events",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
