using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGallery.Migrations
{
    public partial class AddPaintingBuyerRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuyerId",
                table: "Paintings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_BuyerId",
                table: "Paintings",
                column: "BuyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Buyers_BuyerId",
                table: "Paintings",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "ByrID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Buyers_BuyerId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_BuyerId",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "Paintings");
        }
    }
}
