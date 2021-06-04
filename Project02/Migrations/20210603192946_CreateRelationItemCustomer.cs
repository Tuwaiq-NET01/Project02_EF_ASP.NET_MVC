using Microsoft.EntityFrameworkCore.Migrations;

namespace Project01.Migrations
{
    public partial class CreateRelationItemCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerModelId",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_CustomerModelId",
                table: "Items",
                column: "CustomerModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Customers_CustomerModelId",
                table: "Items",
                column: "CustomerModelId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Customers_CustomerModelId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CustomerModelId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CustomerModelId",
                table: "Items");
        }
    }
}
