using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringCoffee2.Migrations
{
    public partial class customerRelationsSFO2M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "SweetAndFood",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SweetAndFood_CustomerId",
                table: "SweetAndFood",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SweetAndFood_Customer_CustomerId",
                table: "SweetAndFood",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SweetAndFood_Customer_CustomerId",
                table: "SweetAndFood");

            migrationBuilder.DropIndex(
                name: "IX_SweetAndFood_CustomerId",
                table: "SweetAndFood");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "SweetAndFood");
        }
    }
}
