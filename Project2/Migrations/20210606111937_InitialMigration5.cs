using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class InitialMigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[] { 1, "Rick Sanchez", 1 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[] { 2, "Morty Smith", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
