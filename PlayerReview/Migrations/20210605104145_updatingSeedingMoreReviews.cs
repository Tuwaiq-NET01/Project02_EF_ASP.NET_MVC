using Microsoft.EntityFrameworkCore.Migrations;

namespace PlayerReview.Migrations
{
    public partial class updatingSeedingMoreReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "GameId", "Title" },
                values: new object[] { 9, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", 4, "Very great game" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "GameId", "Title" },
                values: new object[] { 10, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", 4, "I had so much fun!" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Username",
                value: "Robert");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "ReviewId", "Username" },
                values: new object[] { 9, "User@example.com", "123", 9, "Jake" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "ReviewId", "Username" },
                values: new object[] { 10, "User@example.com", "123", 10, "Jimmy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Username",
                value: "Mohammed");
        }
    }
}
