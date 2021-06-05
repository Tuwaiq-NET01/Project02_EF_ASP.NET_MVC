using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class addRelCarCateg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCategories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryID",
                table: "Cars",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categories_CategoryID",
                table: "Cars",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categories_CategoryID",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CategoryID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Cars");

            migrationBuilder.CreateTable(
                name: "CarCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategories", x => x.Id);
                });
        }
    }
}
