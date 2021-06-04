using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_MVC.Migrations
{
    public partial class EditBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cover",
                value: "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1503755688l/3438000.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cover",
                value: "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1391417857l/20701715.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Cover",
                value: "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1170803558l/72193.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cover",
                value: "http://books.google.com/books/content?id=ev1KDAAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cover",
                value: "http://books.google.com/books/content?id=cvPvsgEACAAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Cover",
                value: "http://books.google.com/books/content?id=HksgDQAAQBAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api");
        }
    }
}
