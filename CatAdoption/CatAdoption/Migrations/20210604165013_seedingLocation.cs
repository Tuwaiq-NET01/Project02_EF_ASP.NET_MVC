using Microsoft.EntityFrameworkCore.Migrations;

namespace CatAdoption.Migrations
{
    public partial class seedingLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "location",
                columns: new[] { "id", "address", "name", "phone" },
                values: new object[] { 1, "505 broadway st", "Vetsreet", "303849244" });

            migrationBuilder.InsertData(
                table: "location",
                columns: new[] { "id", "address", "name", "phone" },
                values: new object[] { 2, "404 broadway st", "Pawpatrol", "758348939" });

            migrationBuilder.InsertData(
                table: "location",
                columns: new[] { "id", "address", "name", "phone" },
                values: new object[] { 3, "303 broadway st", "smartPet", " 7548484844 " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
