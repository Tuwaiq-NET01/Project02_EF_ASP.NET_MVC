using Microsoft.EntityFrameworkCore.Migrations;

namespace furnitureStore.Migrations
{
    public partial class AddMoreSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "CategorisId", "Category", "Image", "Name", "Price" },
                values: new object[] { 4, null, 0, "https://www.woods-furniture.co.uk/images/products/large/7710.jpg", "Sofa 3 Seater  ", 4000.0 });

            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "CategorisId", "Category", "Image", "Name", "Price" },
                values: new object[] { 5, null, 0, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/walmart-sofa-1538774260.jpg?crop=0.923xw:0.462xh;0.0657xw,0.401xh&resize=1200:*", "Sofa", 700.0 });

            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "CategorisId", "Category", "Image", "Name", "Price" },
                values: new object[] { 6, null, 0, "https://cdn.shopify.com/s/files/1/0104/1524/3330/products/zoco-home-furnitures-furnitures-tables-round-dining-table-140cm-tab1014-11553669251138_1000x1000.png?v=1606681288", "Round dining table", 600.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
