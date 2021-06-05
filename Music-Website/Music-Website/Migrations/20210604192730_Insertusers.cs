using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Website.Migrations
{
    public partial class Insertusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Email", "username" },
                values: new object[] { 1, "AAJ@gmail.com", "AAJ" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Email", "username" },
                values: new object[] { 2, "user2@gmail.com", "user2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Email", "username" },
                values: new object[] { 3, "user3@gmail.com", "user3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
