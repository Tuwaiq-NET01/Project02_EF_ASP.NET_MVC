using Microsoft.EntityFrameworkCore.Migrations;

namespace project_management.Migrations
{
    public partial class addSeed_department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departements",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Human Resources" },
                    { 2L, "IT" },
                    { 3L, "Finance" },
                    { 4L, "Marketing" },
                    { 5L, "Operations" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
