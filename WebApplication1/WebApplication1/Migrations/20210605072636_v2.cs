using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "placeId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_placeId",
                table: "Comment",
                column: "placeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Place_placeId",
                table: "Comment",
                column: "placeId",
                principalTable: "Place",
                principalColumn: "placeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Place_placeId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_placeId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "placeId",
                table: "Comment");
        }
    }
}
