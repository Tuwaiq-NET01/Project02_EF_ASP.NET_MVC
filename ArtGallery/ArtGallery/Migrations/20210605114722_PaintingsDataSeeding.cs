using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGallery.Migrations
{
    public partial class PaintingsDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "PntId", "ArtistId", "BuyerId", "GalleryId", "PntImg", "PntName", "PntOverview", "PntPrice" },
                values: new object[,]
                {
                    { 1, 1, 2, 1, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/AngeloAccardi-StandingTogether.1_1_1100x.jpg?v=1596095563", "STANDING TOGETHER", "3D Multilayered Papercut 108x143 cm | 42x56 in Limited Edition", 10400.0 },
                    { 2, 1, 3, 2, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/AngeloAccardi-LookingDown.1_1_1100x.jpg?v=1606219907", "LOOKING DOWN", "3D Multilayered Papercut 80x100 cm | 31x39 in Limited Edition", 8300.0 },
                    { 3, 1, 2, 3, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/AngeloAccardi-AbbeyRoad.1_860x.jpg?v=1596111743", "ABBEY ROAD", "3D Multilayered Papercut 56x75 cm | 22x29 in Limited Edition", 5200.0 },
                    { 4, 2, 4, 4, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/Lescordesdemoname-2_1_1100x.jpg?v=1606229671", "LES CORDES DE MON AME", "Lacquer on metal 30x24 cm | 11x9 in Limited Editio", 1600.0 },
                    { 5, 2, 5, 5, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/BouquetduParadis-2_1_1100x.jpg?v=1605538407", "BOUQUET DU PARADIS", "Lacquer on Metal 30x24 cm | 11x9 in Limited Edition", 2600.0 },
                    { 6, 2, 2, 6, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/Sensiblecommelesfleurs-2_1_1100x.jpg?v=1606403544", "SENSIBLE COMME LES FLEURS", "Lacquer on metal 30x24 cm | 11x9 in Limited Editio", 4600.0 },
                    { 7, 3, 6, 7, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/COVERGIRLMarilyn_1_1100x.jpg?v=1606836043", "COVER GIRL MARILYN MONROE", "Mixed Media Painting 120x76 cm | 47x29 in", 5170.0 },
                    { 8, 3, 1, 8, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/JUSTAMOUSE__1_1100x.jpg?v=1606833970", "JUST A MOUSE", "Mixed Media Painting 40x67 cm | 15x26 in", 5188.0 },
                    { 9, 3, 2, 9, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/THELASTSTAR__1_1100x.jpg?v=1606833845", "THE LAST STAR", "Mixed Media Painting 175x95 cm | 68x37 in", 4600.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 9);
        }
    }
}
