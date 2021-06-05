using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class addRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CarId",
                table: "Customers",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_StoreId",
                table: "Cars",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Store_StoreId",
                table: "Cars",
                column: "StoreId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Cars_CarId",
                table: "Customers",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Store_StoreId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Cars_CarId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CarId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Cars_StoreId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Cars");
        }
    }
}
