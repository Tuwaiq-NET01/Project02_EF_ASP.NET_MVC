using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_MVC.Migrations
{
    public partial class InsertReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Content", "UserId" },
                values: new object[] { 1, 6, "So amazing. I can see many rereads of this in the years to come.", 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Content", "UserId" },
                values: new object[] { 2, 5, "The BEST of J. K. Rowling", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "raneen.ayman@gmail.com", "1234567" },
                    { 2, "haneen.Saad@gmail.com", "123456" },
                    { 3, "Ahmad.Salim@gmail.com", "12345" },
                    { 4, "Steve.Hobes@gmail.com", "123456" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Avatar", "Bio", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "https://semantic-ui.com/images/avatar2/large/molly.png", "“Books are a uniquely portable magic.” – Stephen King", "Raneen Ayman", 1 },
                    { 2, "https://semantic-ui.com/images/avatar2/large/kristy.png", "A good book is an event in my life.", "Haneen Saad", 2 },
                    { 3, "https://semantic-ui.com/images/avatar2/large/elyse.png", "Reading… a vacation for the mind… ", "Ahmad Salim", 3 },
                    { 4, "https://semantic-ui.com/images/avatar/large/steve.jpg", "Innovation distinguishes between a leader and a follower.", "Steve Hobes", 4 }
                });
        }
    }
}
