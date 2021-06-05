using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace BooksStoreMVC.Migrations
{
    public partial class Authers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ConID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ConID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ConID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ConID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ConID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ConID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ConID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contributors",
                keyColumn: "ConID",
                keyValue: 8);

            migrationBuilder.CreateTable(
                name: "Authers",
                columns: table => new
                {
                    AuthId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AuthPhone = table.Column<string>(nullable: true),
                    AuthName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authers", x => x.AuthId);
                });

            migrationBuilder.InsertData(
                table: "Authers",
                columns: new[] { "AuthId", "AuthName", "AuthPhone" },
                values: new object[,]
                {
                    { 1, "Rana Majed", "0555555555" },
                    { 2, "Lama Majed", "0555555556" },
                    { 3, "Saud Majed", "0555555557" },
                    { 4, "Reema Majed", "0555555558" },
                    { 5, "Nawal Nasser", "0555555559" },
                    { 6, "Fatimah Saad", "0555555599" },
                    { 7, "Aishah Majed", "0555555599" },
                    { 8, "Razan Saud", "0555555599" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authers");

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
    }
}
