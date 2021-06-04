using Microsoft.EntityFrameworkCore.Migrations;

namespace Project01.Migrations
{
    public partial class addDatatoCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CustomerId", "ItemID", "Quantity" },
                values: new object[] { 1, 0, null, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
