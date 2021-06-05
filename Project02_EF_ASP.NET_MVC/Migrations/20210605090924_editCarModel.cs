using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class editCarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Cars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cars",
                type: "text",
                nullable: true);
        }
    }
}
