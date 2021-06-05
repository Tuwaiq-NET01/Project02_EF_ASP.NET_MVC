using Microsoft.EntityFrameworkCore.Migrations;

namespace CatAdoption.Migrations
{
    public partial class SeedingCatAndLocation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "location",
                columns: new[] { "id", "address", "name", "phone" },
                values: new object[] { 7, "30 broadway st2", "kittycat2", " 85454995042 " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: 7);
        }
    }
}
