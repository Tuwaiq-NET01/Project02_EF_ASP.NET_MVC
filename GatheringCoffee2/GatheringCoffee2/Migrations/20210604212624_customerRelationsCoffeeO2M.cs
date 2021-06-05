using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class customerRelationsCoffeeO2M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Coffee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Coffee_CustomerId",
                table: "Coffee",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coffee_Customer_CustomerId",
                table: "Coffee",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coffee_Customer_CustomerId",
                table: "Coffee");

            migrationBuilder.DropIndex(
                name: "IX_Coffee_CustomerId",
                table: "Coffee");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Coffee");
        }
    }
}
