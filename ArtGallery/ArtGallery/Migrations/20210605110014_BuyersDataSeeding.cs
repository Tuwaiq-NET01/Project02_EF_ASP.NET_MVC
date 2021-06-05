using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGallery.Migrations
{
    public partial class BuyersDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "ByrID", "ByrMail", "ByrName", "ByrPhone" },
                values: new object[,]
                {
                    { 1, "Jack@dns.com", "Jack", 9665964 },
                    { 2, "mir@dns.com", "Mirry", 9345677 },
                    { 3, "elsi@dns.com", "Elias", 4567899 },
                    { 4, "ram@dns.com", "Ramii", 3456789 },
                    { 5, "vic@dns.com", "vicku", 2345678 },
                    { 6, "rs@dns.com", "rose", 3548765 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 6);
        }
    }
}
