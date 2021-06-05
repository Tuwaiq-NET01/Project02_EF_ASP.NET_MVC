using Microsoft.EntityFrameworkCore.Migrations;

namespace CatAdoption.Migrations
{
    public partial class createCatLocationRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "cat",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_cat_LocationId",
                table: "cat",
                column: "LocationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_cat_location_LocationId",
                table: "cat",
                column: "LocationId",
                principalTable: "location",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cat_location_LocationId",
                table: "cat");

            migrationBuilder.DropIndex(
                name: "IX_cat_LocationId",
                table: "cat");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "cat");
        }
    }
}
