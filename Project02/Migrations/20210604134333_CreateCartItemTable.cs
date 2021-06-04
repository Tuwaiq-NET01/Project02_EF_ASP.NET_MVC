using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Project01.Migrations
{
    public partial class CreateCartItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CustomerId",
                table: "Items",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ItemID",
                table: "CartItems",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Customers_CustomerId",
                table: "Items",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Customers_CustomerId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_Items_CustomerId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "CustomerModelId",
                table: "Items",
                type: "int",
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
    }
}
