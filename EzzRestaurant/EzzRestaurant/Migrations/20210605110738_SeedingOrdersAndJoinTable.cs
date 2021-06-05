using Microsoft.EntityFrameworkCore.Migrations;

namespace EzzRestaurant.Migrations
{
    public partial class SeedingOrdersAndJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "TotalPrice", "UserId" },
                values: new object[] { 1, 35.0, 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "TotalPrice", "UserId" },
                values: new object[] { 2, 156.0, 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "TotalPrice", "UserId" },
                values: new object[] { 3, 21.0, 2 });

            migrationBuilder.InsertData(
                table: "OrderProduct",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 8 },
                    { 2, 1, 5 },
                    { 3, 2, 1 },
                    { 4, 2, 3 },
                    { 5, 2, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
