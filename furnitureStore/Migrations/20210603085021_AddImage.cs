using Microsoft.EntityFrameworkCore.Migrations;

namespace furnitureStore.Migrations
{
    public partial class AddImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "furnitures",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://shop.static.ingka.ikea.com/revamp/dining-sets-up-to-6-seats_36213.jpg");

            migrationBuilder.UpdateData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://storage.sg.content-cdn.io/cdn-cgi/image/width=479,height=239,quality=75,format=auto,fit=contain,g=top/in-resources/ee3f4ad5-f5ba-49b3-a2e8-f65bbba20ae3/Images/ProductImages/Source/Bantia%20Jamaica%20Marble4_01.jpg");

            migrationBuilder.UpdateData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/61HkfQlM4PL._AC_UL320_.jpg");

            migrationBuilder.InsertData(
                table: "furnitures",
                columns: new[] { "Id", "Image", "Name", "Price" },
                values: new object[] { 1, "https://www.huntersfurniture.co.uk/images/products/standard/4508.jpg", "Sofas", 3000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "furnitures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Image",
                table: "furnitures");
        }
    }
}
