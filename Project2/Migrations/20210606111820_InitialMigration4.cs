using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class InitialMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CharacterStatus",
                columns: new[] { "Id", "Status" },
                values: new object[] { 1, "Alive" });

            migrationBuilder.InsertData(
                table: "CharacterStatus",
                columns: new[] { "Id", "Status" },
                values: new object[] { 2, "Dead" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CharacterStatus",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
