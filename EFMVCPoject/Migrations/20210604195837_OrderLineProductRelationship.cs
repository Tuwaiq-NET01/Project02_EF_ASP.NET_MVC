using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMVCPoject.Migrations
{
    public partial class OrderLineProductRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderLineID",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderLineID",
                table: "Products",
                column: "OrderLineID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OrderLines_OrderLineID",
                table: "Products",
                column: "OrderLineID",
                principalTable: "OrderLines",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_OrderLines_OrderLineID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderLineID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderLineID",
                table: "Products");
        }
    }
}
