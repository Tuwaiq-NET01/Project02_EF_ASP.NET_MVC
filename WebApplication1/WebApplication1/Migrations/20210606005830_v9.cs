using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Address_placeId",
                table: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_Address_placeId",
                table: "Address",
                column: "placeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Address_placeId",
                table: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_Address_placeId",
                table: "Address",
                column: "placeId",
                unique: true);
        }
    }
}
