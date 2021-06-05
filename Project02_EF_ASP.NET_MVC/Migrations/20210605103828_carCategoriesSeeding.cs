using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class carCategoriesSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Electric" });

            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Gasoline" });

            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Diesel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
