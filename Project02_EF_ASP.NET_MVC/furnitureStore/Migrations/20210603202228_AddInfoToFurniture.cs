using Microsoft.EntityFrameworkCore.Migrations;

namespace furnitureStore.Migrations
{
    public partial class AddInfoToFurniture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "CategorisId", "Category", "Image", "Name", "Price" },
                values: new object[] { 4, null, 0, "https://images2.imgix.net/p4dbimg/1050/images/x-virtual-438.jpg?trim=color&trimcolor=FFFFFF&trimtol=5&w=1024&h=768&fm=pjpg&auto=format", "dining sets up to 6 seats", 600.0 });
        }
    }
}
