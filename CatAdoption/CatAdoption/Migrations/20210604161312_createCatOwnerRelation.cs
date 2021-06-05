using Microsoft.EntityFrameworkCore.Migrations;

namespace CatAdoption.Migrations
{
    public partial class createCatOwnerRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "cat",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_cat_OwnerId",
                table: "cat",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_cat_owner_OwnerId",
                table: "cat",
                column: "OwnerId",
                principalTable: "owner",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cat_owner_OwnerId",
                table: "cat");

            migrationBuilder.DropIndex(
                name: "IX_cat_OwnerId",
                table: "cat");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "cat");
        }
    }
}
