using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace BooksStoreMVC.Migrations
{
    public partial class Publishers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PubId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PubPhone = table.Column<string>(nullable: true),
                    PubName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PubId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
