using Microsoft.EntityFrameworkCore.Migrations;

namespace PlayerReview.Migrations
{
    public partial class changedReviewGamesUserModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "ReviewId", "Username" },
                values: new object[,]
                {
                    { 1, "User@example.com", "123", 0, "Jake" },
                    { 2, "User@example.com", "123", 0, "John" },
                    { 3, "User@example.com", "123", 0, "Drake" },
                    { 4, "User@example.com", "123", 0, "Michael" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
