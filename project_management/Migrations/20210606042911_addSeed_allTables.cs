using Microsoft.EntityFrameworkCore.Migrations;

namespace project_management.Migrations
{
    public partial class addSeed_allTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1L, 2L, "Mohammed_0001@company.com", "Mohammed", "Al-Harbi" },
                    { 2L, 2L, "Abdulrahman_0021@company.com", "Abdulrahman", "Bin Manea" },
                    { 3L, 2L, "Sara_0165@company.com", "Sara", "Al-Qahtani" },
                    { 4L, 1L, "Mohammed_0123@company.com", "Mohammed", "Al-Solami" },
                    { 5L, 3L, "Sultan_1000@company.com", "Sultan", "Al-Ghamdi" },
                    { 6L, 5L, "Salim_0701@company.com", "Salim", "Al-Harthi" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "DepId", "Description", "Name", "ProjectMgrId" },
                values: new object[] { 1L, 2L, "it's a secret", "Secret Project", 2L });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "EmpId", "ProjectId" },
                values: new object[] { 1L, "Design the system architecture", 3L, 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
