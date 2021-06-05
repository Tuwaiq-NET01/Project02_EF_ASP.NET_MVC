using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryBook.Migrations
{
    public partial class SeedingBookAuthorManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "BookID", "AuthorID", "BAId" },
                values: new object[] { 1, 1, 0 });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "BookID", "AuthorID", "BAId" },
                values: new object[] { 2, 2, 0 });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "BookID", "AuthorID", "BAId" },
                values: new object[] { 1, 3, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "BookID", "AuthorID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "BookID", "AuthorID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "BookID", "AuthorID" },
                keyValues: new object[] { 2, 2 });
        }
    }
}
