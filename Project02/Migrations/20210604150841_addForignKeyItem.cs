using Microsoft.EntityFrameworkCore.Migrations;

namespace Project01.Migrations
{
    public partial class addForignKeyItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Items_ItemID",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_ItemID",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "Carts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
    name: "CartID",
    table: "Items",
    type: "int",
    nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_CartID",
                table: "Items",
                column: "CartID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Carts_CartID",
                table: "Items",
                column: "CartID",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
