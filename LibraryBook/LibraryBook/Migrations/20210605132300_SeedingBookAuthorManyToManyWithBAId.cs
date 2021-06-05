using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryBook.Migrations
{
    public partial class SeedingBookAuthorManyToManyWithBAId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumns: new[] { "BookID", "AuthorID" },
                keyValues: new object[] { 1, 1 },
                column: "BAId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumns: new[] { "BookID", "AuthorID" },
                keyValues: new object[] { 1, 3 },
                column: "BAId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumns: new[] { "BookID", "AuthorID" },
                keyValues: new object[] { 2, 2 },
                column: "BAId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumns: new[] { "BookID", "AuthorID" },
                keyValues: new object[] { 1, 1 },
                column: "BAId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumns: new[] { "BookID", "AuthorID" },
                keyValues: new object[] { 1, 3 },
                column: "BAId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumns: new[] { "BookID", "AuthorID" },
                keyValues: new object[] { 2, 2 },
                column: "BAId",
                value: 0);
        }
    }
}
