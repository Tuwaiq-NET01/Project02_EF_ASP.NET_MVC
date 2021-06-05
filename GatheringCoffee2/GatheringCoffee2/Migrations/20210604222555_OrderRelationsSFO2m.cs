using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class OrderRelationsSFO2m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "SweetAndFood",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SweetAndFood_OrderId",
                table: "SweetAndFood",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SweetAndFood_Order_OrderId",
                table: "SweetAndFood",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SweetAndFood_Order_OrderId",
                table: "SweetAndFood");

            migrationBuilder.DropIndex(
                name: "IX_SweetAndFood_OrderId",
                table: "SweetAndFood");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "SweetAndFood");
        }
    }
}
