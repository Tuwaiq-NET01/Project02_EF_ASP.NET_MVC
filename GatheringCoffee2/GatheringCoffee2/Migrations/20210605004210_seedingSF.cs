using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class seedingSF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SweetAndFood",
                columns: new[] { "Id", "Description", "Image", "Name", "OrderId", "Price", "SweetAndFoodCategoryId" },
                values: new object[,]
                {
                    { 1, "This is the nice Pistachio cake", "/img/Pistachio-cake.jpeg", "Pistachio-cake", null, 28f, 1 },
                    { 2, "This is the nice Brawn cake", "/img/Brown-cake.jpeg", "Brown-cake", null, 23f, 1 },
                    { 3, "This is the nice Tiramisu Cake", "/img/Tiramisu-Cake.jpg", "Tiramisu-Cake", null, 25f, 1 },
                    { 4, "This is the nice Haloumi-Sandwish It consists of halloumi added to it, tomatoes, olive oil and thyme", "/img/Haloumi-Sandwish.jpeg", "Haloumi-Sandwish", null, 20f, 2 },
                    { 5, "This is the nice Croissant It consists of nice cheese", "/img/Croissant.jpeg", "Croissant", null, 14f, 2 },
                    { 6, "This is the nice Croissant It consists of nice Labnah dich and Egg dich ", "/img/Break-Fast.jpeg", "Break-Fast", null, 30f, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SweetAndFood",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SweetAndFood",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SweetAndFood",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SweetAndFood",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SweetAndFood",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SweetAndFood",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
