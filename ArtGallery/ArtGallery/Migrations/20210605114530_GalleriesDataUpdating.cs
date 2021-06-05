using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGallery.Migrations
{
    public partial class GalleriesDataUpdating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "GlrId", "GlrImg", "GlrLocation", "GlrName" },
                values: new object[,]
                {
                    { 4, "https://imgmediagumlet.lbb.in/media/2019/03/5c9b5aeac394967ce2d1f1f3_1553685226709.jpg?fm=webp&w=750&h=500&dpr=1", "Mumbai", "Volte2" },
                    { 5, "https://imgmediagumlet.lbb.in/media/2019/04/5cbdad06b62ad10704e9f804_1555934470151.jpg?fm=webp&w=750&h=500&dpr=1", "London", "Gallery Chemould2" },
                    { 6, "https://gulfbusiness.com/wp-content/uploads/2021/02/Website-Grosvenor-Gallery-London-Art-Dubai-Modern-March-20-Art-Dubai-2019-Courtesy-of-Photo-Solutions-3-1.jpg", "Dubai", "Art Dubai2" },
                    { 7, "https://imgmediagumlet.lbb.in/media/2019/03/5c9b5aeac394967ce2d1f1f3_1553685226709.jpg?fm=webp&w=750&h=500&dpr=1", "Mumbai", "Volte3" },
                    { 8, "https://imgmediagumlet.lbb.in/media/2019/04/5cbdad06b62ad10704e9f804_1555934470151.jpg?fm=webp&w=750&h=500&dpr=1", "London", "Gallery Chemould3" },
                    { 9, "https://gulfbusiness.com/wp-content/uploads/2021/02/Website-Grosvenor-Gallery-London-Art-Dubai-Modern-March-20-Art-Dubai-2019-Courtesy-of-Photo-Solutions-3-1.jpg", "Dubai", "Art Dubai3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 9);
        }
    }
}
