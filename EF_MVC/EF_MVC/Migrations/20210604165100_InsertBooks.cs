using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_MVC.Migrations
{
    public partial class InsertBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Cover", "Title" },
                values: new object[,]
                {
                    { 1, "William Golding", "http://books.google.com/books/content?id=r6eoCwAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api", "Lord of the Flies" },
                    { 2, "رضوى عاشور", "http://books.google.com/books/content?id=ev1KDAAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api", "ثلاثية غرناطة" },
                    { 3, "خالد حسيني", "http://books.google.com/books/content?id=cvPvsgEACAAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api", "و رددت الجبال الصدى" },
                    { 4, "كيم إكلين", "http://books.google.com/books/content?id=Of6vDQAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api", "في ظل الحياة المرئية" },
                    { 5, "J. K. Rowling", "http://books.google.com/books/content?id=HksgDQAAQBAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api", "Harry Potter and the Philosopher's Stone" },
                    { 6, "Antoine de Saint-Exupéry", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1367545443l/157993.jpg", "The Little Prince" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
