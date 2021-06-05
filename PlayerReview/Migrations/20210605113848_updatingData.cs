using Microsoft.EntityFrameworkCore.Migrations;

namespace PlayerReview.Migrations
{
    public partial class updatingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://i.pinimg.com/originals/cf/db/45/cfdb458b0f4e5ec157da2a0f4787cc66.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Very great game.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://lh3.googleusercontent.com/proxy/Xb1jfc8iI2vPhYM_N2kvbmCjQIyYc0n6RX2wBGT-MhbXjB63DygrF2vIlyi_3jxajbHsPy9-6u3fPRmadwTWktwEB0ypGLcxjb3O0FWSUt7FFG8ykhJQJiXMj3lmizjSS-tYEIjHy7g");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Very great game");
        }
    }
}
