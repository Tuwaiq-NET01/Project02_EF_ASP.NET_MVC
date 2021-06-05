using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class seedingCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "PhoneNum" },
                values: new object[] { 1, "Hussain", "0567800818" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "PhoneNum" },
                values: new object[] { 2, "Meshal", "0507999706" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "PhoneNum" },
                values: new object[] { 3, "Thamer", "0551609938" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
