using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace BooksStoreMVC.Migrations
{
    public partial class Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PubId",
                keyValue: 8);

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ISBN = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    PublisherPubId = table.Column<int>(nullable: true),
                    PubId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherPubId",
                        column: x => x.PublisherPubId,
                        principalTable: "Publishers",
                        principalColumn: "PubId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "Price", "PubId", "PublisherPubId", "Title" },
                values: new object[,]
                {
                    { 1234, 15.6, 0, null, "C# book" },
                    { 1233, 20.899999999999999, 0, null, "Java book" },
                    { 1235, 15.6, 0, null, "Design Pattren book" },
                    { 1236, 55.0, 0, null, "MVC book" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherPubId",
                table: "Books",
                column: "PublisherPubId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PubId", "PubName", "PubPhone" },
                values: new object[,]
                {
                    { 1, "Nada Majed", "0555555555" },
                    { 2, "Arwa Majed", "0555555556" },
                    { 3, "Raghad Majed", "0555555557" },
                    { 4, "Lana Majed", "0555555558" },
                    { 5, "Nadiyah Nasser", "0555555559" },
                    { 6, "Majed Saad", "0555555599" },
                    { 7, "Saad Majed", "0555555599" },
                    { 8, "Mohammed Abdullah", "0555555599" }
                });
        }
    }
}
