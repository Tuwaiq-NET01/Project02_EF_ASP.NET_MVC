using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class r : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coffee_Customer_CustomerId",
                table: "Coffee");

            migrationBuilder.DropForeignKey(
                name: "FK_SweetAndFood_Customer_CustomerId",
                table: "SweetAndFood");

            migrationBuilder.DropIndex(
                name: "IX_SweetAndFood_CustomerId",
                table: "SweetAndFood");

            migrationBuilder.DropIndex(
                name: "IX_Coffee_CustomerId",
                table: "Coffee");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "SweetAndFood");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Coffee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "SweetAndFood",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Coffee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SweetAndFood_CustomerId",
                table: "SweetAndFood",
                column: "CustomerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SweetAndFood_Customer_CustomerId",
                table: "SweetAndFood",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
