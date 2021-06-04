using Microsoft.EntityFrameworkCore.Migrations;

namespace Project01.Migrations
{
    public partial class addItemsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "Description", "Image", "Name", "Price", "Quantity", "Type" },
                values: new object[] { 1, "Yallow banana from south africa", "http://cdn.shopify.com/s/files/1/2154/4937/products/banana_600x.jpg?v=1610541466", "Banana", 10m, 1, "Fruit" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "Description", "Image", "Name", "Price", "Quantity", "Type" },
                values: new object[] { 2, "Yallow banana from south africa", "http://cdn.shopify.com/s/files/1/2154/4937/products/banana_600x.jpg?v=1610541466", "Banana", 10m, 1, "Fruit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
