using Microsoft.EntityFrameworkCore.Migrations;

namespace Crystal_circus.Migrations
{
    public partial class ShowandVenueRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VenueId",
                table: "Shows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Shows_VenueId",
                table: "Shows",
                column: "VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Venues_VenueId",
                table: "Shows",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Venues_VenueId",
                table: "Shows");

            migrationBuilder.DropIndex(
                name: "IX_Shows_VenueId",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "VenueId",
                table: "Shows");
        }
    }
}
