using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Address_placeId",
                table: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_Address_placeId",
                table: "Address",
                column: "placeId");
        }
    }
}
