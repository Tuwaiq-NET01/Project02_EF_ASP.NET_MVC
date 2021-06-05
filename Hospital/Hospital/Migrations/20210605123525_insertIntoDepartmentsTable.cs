using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Migrations
{
    public partial class insertIntoDepartmentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name", "PhysicianId" },
                values: new object[] { 27, "Cardiology", 1113 });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name", "PhysicianId" },
                values: new object[] { 66, "Internal medicine", 1111 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 66);
        }
    }
}
