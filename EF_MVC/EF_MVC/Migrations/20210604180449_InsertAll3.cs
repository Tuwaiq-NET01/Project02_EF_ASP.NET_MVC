using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_MVC.Migrations
{
    public partial class InsertAll3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Cover", "Title" },
                values: new object[,]
                {
                    { 7, "Matt Haig", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1602190253l/52578297.jpg", "The Midnight Library" },
                    { 8, "Emily St. John Mandel", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1564199892l/45754981.jpg", "The Glass Hotel" },
                    { 9, "Abi Daré", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1581128232l/50214741.jpg", "The Girl with the Louding Voice" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[] { 5, "JoeNadal@gmail.com", "123456" });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Avatar", "Bio", "Name", "UserId" },
                values: new object[] { 5, "https://semantic-ui.com/images/avatar/large/jenny.jpg", "Reading one book is like eating one potato chip", "Joe Nadal", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
