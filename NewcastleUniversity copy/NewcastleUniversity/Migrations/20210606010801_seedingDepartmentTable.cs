using Microsoft.EntityFrameworkCore.Migrations;

namespace NewcastleUniversity.Migrations
{
    public partial class seedingDepartmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Inforamtion Technology" });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Computer Science" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
