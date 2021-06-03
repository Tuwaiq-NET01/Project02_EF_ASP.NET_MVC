using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02_EF_MVC.Migrations
{
    public partial class SeedingCourseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: 1010);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: 0);
        }
    }
}
