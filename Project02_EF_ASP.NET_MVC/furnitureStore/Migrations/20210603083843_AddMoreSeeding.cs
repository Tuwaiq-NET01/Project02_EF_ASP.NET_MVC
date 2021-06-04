using Microsoft.EntityFrameworkCore.Migrations;

namespace furnitureStore.Migrations
{
    public partial class AddMoreSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "Dining sets up to 6 seats", 2000.0 });

            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Dining sets up to 4 seats", 1500.0 });

            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 4, "Dining sets up to 2 seats", 800.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Sofas", 3000.0 });
        }
    }
}
