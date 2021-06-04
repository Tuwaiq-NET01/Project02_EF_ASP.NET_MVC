using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMVCPoject.Migrations
{
    public partial class OrderLinesOrderRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "OrderLines",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderID",
                table: "OrderLines",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Orders_OrderID",
                table: "OrderLines",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderID",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_OrderID",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "OrderLines");
        }
    }
}
