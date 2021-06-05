using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class seedingOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId" },
                values: new object[] { 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
