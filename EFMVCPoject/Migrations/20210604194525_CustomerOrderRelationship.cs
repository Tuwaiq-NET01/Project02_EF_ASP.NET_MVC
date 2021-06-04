using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMVCPoject.Migrations
{
    public partial class CustomerOrderRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_OrderID",
                table: "Customers",
                column: "OrderID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Orders_OrderID",
                table: "Customers",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Orders_OrderID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_OrderID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Customers");
        }
    }
}
