using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_MVC.Migrations
{
    public partial class EditBooks2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cover",
                value: "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327869409l/7624.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cover",
                value: "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1481285373l/33297809._SX318_.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cover",
                value: "http://books.google.com/books/content?id=r6eoCwAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cover",
                value: "http://books.google.com/books/content?id=Of6vDQAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api");
        }
    }
}
