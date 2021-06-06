using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class CustomersGiftsRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Gifts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Gifts_CustomerID",
                table: "Gifts",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gifts_Customers_CustomerID",
                table: "Gifts",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gifts_Customers_CustomerID",
                table: "Gifts");

            migrationBuilder.DropIndex(
                name: "IX_Gifts_CustomerID",
                table: "Gifts");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Gifts");
        }
    }
}
