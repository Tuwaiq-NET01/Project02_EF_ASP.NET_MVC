using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_MVC.Migrations
{
    public partial class InsertAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
