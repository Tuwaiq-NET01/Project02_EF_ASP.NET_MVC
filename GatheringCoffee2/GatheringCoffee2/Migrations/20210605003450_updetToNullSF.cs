using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class updetToNullSF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SweetAndFood_Order_OrderId",
                table: "SweetAndFood");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "SweetAndFood",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SweetAndFood_Order_OrderId",
                table: "SweetAndFood",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SweetAndFood_Order_OrderId",
                table: "SweetAndFood");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "SweetAndFood",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SweetAndFood_Order_OrderId",
                table: "SweetAndFood",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
