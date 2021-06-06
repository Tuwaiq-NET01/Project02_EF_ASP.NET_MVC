using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class InitialMigration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserFavorites",
                columns: new[] { "UserId", "CharacterId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "UserFavorites",
                columns: new[] { "UserId", "CharacterId" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserFavorites",
                keyColumns: new[] { "UserId", "CharacterId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserFavorites",
                keyColumns: new[] { "UserId", "CharacterId" },
                keyValues: new object[] { 1, 2 });
        }
    }
}
