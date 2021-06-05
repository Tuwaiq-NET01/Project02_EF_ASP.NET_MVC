using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Migrations
{
    public partial class AddSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Location", "NumberOfDepartments", "NumberOfEmployees", "NumberOfManagers" },
                values: new object[] { 1, "Riyadh", 9, 156, 9 });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Location", "NumberOfDepartments", "NumberOfEmployees", "NumberOfManagers" },
                values: new object[] { 2, "Jeddah", 7, 77, 7 });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Location", "NumberOfDepartments", "NumberOfEmployees", "NumberOfManagers" },
                values: new object[] { 3, "Dammam", 4, 51, 4 });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "BranchId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "IT" },
                    { 2, 1, "Sales" },
                    { 3, 2, "Oprations" },
                    { 4, 2, "HR" },
                    { 5, 3, "Content" },
                    { 6, 3, "Development" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "DepartmentId", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 22, 1, true, "Khaled" },
                    { 2, 27, 1, true, "Ahmed" },
                    { 11, 23, 6, false, "Tala" },
                    { 3, 23, 2, false, "Amal" },
                    { 4, 22, 2, false, "Ghada" },
                    { 5, 30, 3, true, "Mohammed" },
                    { 6, 24, 3, true, "Fahad" },
                    { 12, 22, 6, false, "Lena" },
                    { 7, 25, 4, false, "Nora" },
                    { 8, 31, 4, false, "Rahaf" },
                    { 10, 27, 5, true, "Thamer" },
                    { 9, 29, 5, true, "Husaain" }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Age", "DepartmentId", "Gender", "Name" },
                values: new object[,]
                {
                    { 5, 29, 5, false, "Samirah" },
                    { 3, 51, 3, true, "Saad" },
                    { 2, 38, 2, false, "Sara" },
                    { 1, 44, 1, true, "Saud" },
                    { 4, 33, 4, true, "Sami" },
                    { 6, 62, 6, true, "Salem" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
