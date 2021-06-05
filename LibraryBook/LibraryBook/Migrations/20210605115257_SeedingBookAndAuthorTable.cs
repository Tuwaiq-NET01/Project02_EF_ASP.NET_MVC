using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryBook.Migrations
{
    public partial class SeedingBookAndAuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "AuthorEmail", "AuthorFirstName", "AuthorLastName", "Notes" },
                values: new object[,]
                {
                    { 1, "Andrea@mail.com", "Andrea", "Arbasi", "This author has written great" },
                    { 2, "Jan@mail.com", "Jan", "Wengro", "This author has written great" },
                    { 3, "Pon@mail.com", "Pon", "Pattren", "This author has written great" },
                    { 4, "Alexander@mail.com", " Alexander", "Jony", "This author has written great" },
                    { 5, "Mikel@mail.com", "Mikel", "Jon", "This author has written great" },
                    { 6, "Murray@mail.com", " Murray", "Silverstein", "This author has written great" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "IdBookStore", "NoPage", "Notes", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, 530, "Good Book !", 103.5f, "Opertaing System" },
                    { 2, 1, 400, "boring book", 99.5f, "Data Structure" },
                    { 3, 1, 500, "Interesting book", 300.5f, "Software Testing" },
                    { 4, 2, 300, "boring book", 200.9f, "Design Pattren" },
                    { 5, 2, 250, "A very useful book", 90.5f, "Learn How To Learn" },
                    { 6, 2, 100, "Interesting book", 88.5f, "Act Like A Success" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 6);
        }
    }
}
