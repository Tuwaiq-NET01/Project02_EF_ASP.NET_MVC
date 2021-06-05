using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CarModel",
                table: "CarModel");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "CarModel",
                newName: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "CarModel");

            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarModel",
                table: "CarModel",
                column: "Id");
        }
    }
}
