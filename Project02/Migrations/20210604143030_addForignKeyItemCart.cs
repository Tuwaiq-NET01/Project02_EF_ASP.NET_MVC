using Microsoft.EntityFrameworkCore.Migrations;

namespace Project01.Migrations
{
    public partial class addForignKeyItemCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "Carts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ItemID",
                table: "Carts",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Items_ItemID",
                table: "Carts",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
