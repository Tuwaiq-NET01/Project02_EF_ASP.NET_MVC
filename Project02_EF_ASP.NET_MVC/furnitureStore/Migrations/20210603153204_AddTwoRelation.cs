using Microsoft.EntityFrameworkCore.Migrations;

namespace furnitureStore.Migrations
{
    public partial class AddTwoRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorisId",
                table: "furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "furnitures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "paymentId",
                table: "customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_furnitures_CategorisId",
                table: "furnitures",
                column: "CategorisId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_paymentId",
                table: "customers",
                column: "paymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_Payments_paymentId",
                table: "customers",
                column: "paymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_furnitures_Categories_CategorisId",
                table: "furnitures",
                column: "CategorisId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_Payments_paymentId",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_furnitures_Categories_CategorisId",
                table: "furnitures");

            migrationBuilder.DropIndex(
                name: "IX_furnitures_CategorisId",
                table: "furnitures");

            migrationBuilder.DropIndex(
                name: "IX_customers_paymentId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "CategorisId",
                table: "furnitures");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "furnitures");

            migrationBuilder.DropColumn(
                name: "paymentId",
                table: "customers");
        }
    }
}
