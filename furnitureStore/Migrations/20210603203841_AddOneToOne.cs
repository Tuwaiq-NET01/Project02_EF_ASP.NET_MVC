using Microsoft.EntityFrameworkCore.Migrations;

namespace furnitureStore.Migrations
{
    public partial class AddOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_Payments_paymentId",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_paymentId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "paymentId",
                table: "customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CardItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerId",
                table: "Payments",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CardItems_CustomerId",
                table: "CardItems",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CardItems_customers_CustomerId",
                table: "CardItems",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_customers_CustomerId",
                table: "Payments",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardItems_customers_CustomerId",
                table: "CardItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_customers_CustomerId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CustomerId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_CardItems_CustomerId",
                table: "CardItems");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CardItems");

            migrationBuilder.AddColumn<int>(
                name: "paymentId",
                table: "customers",
                type: "int",
                nullable: true);

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
        }
    }
}
