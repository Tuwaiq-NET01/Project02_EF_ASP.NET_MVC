using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class OrderRelationsCoffeeO2m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Coffee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Coffee_OrderId",
                table: "Coffee",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coffee_Order_OrderId",
                table: "Coffee",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coffee_Order_OrderId",
                table: "Coffee");

            migrationBuilder.DropIndex(
                name: "IX_Coffee_OrderId",
                table: "Coffee");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Coffee");
        }
    }
}
