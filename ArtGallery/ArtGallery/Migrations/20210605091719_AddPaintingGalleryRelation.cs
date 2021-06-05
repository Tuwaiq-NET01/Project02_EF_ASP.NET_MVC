using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGallery.Migrations
{
    public partial class AddPaintingGalleryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GalleryId",
                table: "Paintings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_GalleryId",
                table: "Paintings",
                column: "GalleryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Galleries_GalleryId",
                table: "Paintings",
                column: "GalleryId",
                principalTable: "Galleries",
                principalColumn: "GlrId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Galleries_GalleryId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_GalleryId",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "GalleryId",
                table: "Paintings");
        }
    }
}
