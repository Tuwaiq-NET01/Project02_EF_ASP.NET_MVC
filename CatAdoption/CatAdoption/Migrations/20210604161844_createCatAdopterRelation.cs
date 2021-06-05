using Microsoft.EntityFrameworkCore.Migrations;

namespace CatAdoption.Migrations
{
    public partial class createCatAdopterRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdopterId",
                table: "cat",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_cat_AdopterId",
                table: "cat",
                column: "AdopterId");

            migrationBuilder.AddForeignKey(
                name: "FK_cat_adopter_AdopterId",
                table: "cat",
                column: "AdopterId",
                principalTable: "adopter",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cat_adopter_AdopterId",
                table: "cat");

            migrationBuilder.DropIndex(
                name: "IX_cat_AdopterId",
                table: "cat");

            migrationBuilder.DropColumn(
                name: "AdopterId",
                table: "cat");
        }
    }
}
