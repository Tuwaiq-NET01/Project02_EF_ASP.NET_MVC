using Microsoft.EntityFrameworkCore.Migrations;

namespace furnitureStore.Migrations
{
    public partial class AddSeedingToFurnituer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Sofas", 3000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
