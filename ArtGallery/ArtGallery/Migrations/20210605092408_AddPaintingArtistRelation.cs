using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGallery.Migrations
{
    public partial class AddPaintingArtistRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Paintings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_ArtistId",
                table: "Paintings",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Artists_ArtistId",
                table: "Paintings",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Artists_ArtistId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_ArtistId",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Paintings");
        }
    }
}
