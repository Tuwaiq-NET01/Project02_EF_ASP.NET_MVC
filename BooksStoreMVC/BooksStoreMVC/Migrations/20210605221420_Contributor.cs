using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace BooksStoreMVC.Migrations
{
    public partial class Contributor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: 1236);

            migrationBuilder.CreateTable(
                name: "Contributors",
                columns: table => new
                {
                    ConID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ConName = table.Column<string>(nullable: true),
                    ConPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contributors", x => x.ConID);
                });

            migrationBuilder.InsertData(
                table: "Contributors",
                columns: new[] { "ConID", "ConName", "ConPhone" },
                values: new object[,]
                {
                    { 1, "Alzahrah", "0555655654" },
                    { 2, "Alolla", "0535655654" },
                    { 3, "Alressalah", "0545655654" },
                    { 4, "Alrwabe", "056655654" },
                    { 5, "Jarir", "0575655654" },
                    { 6, "Alnada", "0585655654" },
                    { 7, "Alketab", "0595655654" },
                    { 8, "Alward", "05105655654" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contributors");

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
        }
    }
}
