using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cityId",
                table: "Place",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Place_cityId",
                table: "Place",
                column: "cityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Place_City_cityId",
                table: "Place",
                column: "cityId",
                principalTable: "City",
                principalColumn: "cityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Place_City_cityId",
                table: "Place");

            migrationBuilder.DropIndex(
                name: "IX_Place_cityId",
                table: "Place");

            migrationBuilder.DropColumn(
                name: "cityId",
                table: "Place");
        }
    }
}
