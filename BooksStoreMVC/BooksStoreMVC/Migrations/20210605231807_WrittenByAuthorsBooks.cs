using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksStoreMVC.Migrations
{
    public partial class WrittenByAuthorsBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authers",
                keyColumn: "AuthId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authers",
                keyColumn: "AuthId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authers",
                keyColumn: "AuthId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authers",
                keyColumn: "AuthId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authers",
                keyColumn: "AuthId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authers",
                keyColumn: "AuthId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authers",
                keyColumn: "AuthId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authers",
                keyColumn: "AuthId",
                keyValue: 8);

            migrationBuilder.CreateTable(
                name: "WrittenByAuthorsBooks",
                columns: table => new
                {
                    AutherId = table.Column<int>(nullable: false),
                    BookISBN = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WrittenByAuthorsBooks", x => new { x.AutherId, x.BookISBN });
                    table.ForeignKey(
                        name: "FK_WrittenByAuthorsBooks_Authers_AutherId",
                        column: x => x.AutherId,
                        principalTable: "Authers",
                        principalColumn: "AuthId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WrittenByAuthorsBooks_Books_BookISBN",
                        column: x => x.BookISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WrittenByAuthorsBooks_BookISBN",
                table: "WrittenByAuthorsBooks",
                column: "BookISBN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WrittenByAuthorsBooks");

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
    }
}
