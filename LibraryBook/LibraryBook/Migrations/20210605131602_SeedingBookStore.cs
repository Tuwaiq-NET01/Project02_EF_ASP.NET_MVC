using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryBook.Migrations
{
    public partial class SeedingBookStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookStore",
                columns: new[] { "IdBookStore", "EmailOfBookStore", "Location", "NameOfBookStore", "Telephone" },
                values: new object[] { 1, "bs-r@mail.com", "Al-Hamra-Riyadh", " Jarir", "011984430" });

            migrationBuilder.InsertData(
                table: "BookStore",
                columns: new[] { "IdBookStore", "EmailOfBookStore", "Location", "NameOfBookStore", "Telephone" },
                values: new object[] { 2, "bs-j@mail.com", "Al-Manar-Jeddah", " Jarir", "01488994" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "BookStore",
                keyColumn: "IdBookStore",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookStore",
                keyColumn: "IdBookStore",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "IdBookStore", "NoPage", "Notes", "Price", "Title" },
                values: new object[,]
                {
                    { 6, 2, 100, "Interesting book", 88.5f, "Act Like A Success" },
                    { 5, 2, 250, "A very useful book", 90.5f, "Learn How To Learn" },
                    { 4, 2, 300, "boring book", 200.9f, "Design Pattren" },
                    { 3, 1, 500, "Interesting book", 300.5f, "Software Testing" },
                    { 2, 1, 400, "boring book", 99.5f, "Data Structure" },
                    { 1, 1, 530, "Good Book !", 103.5f, "Opertaing System" }
                });
        }
    }
}
