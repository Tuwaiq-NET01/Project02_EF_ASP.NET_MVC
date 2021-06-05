using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Website.Migrations
{
    public partial class Inserratetable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rate",
                columns: new[] { "id", "MusicId", "score" },
                values: new object[] { 2, 2, 5 });

            migrationBuilder.InsertData(
                table: "Rate",
                columns: new[] { "id", "MusicId", "score" },
                values: new object[] { 3, 3, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rate",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rate",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
