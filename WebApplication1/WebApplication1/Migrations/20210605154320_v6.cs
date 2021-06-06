using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "City",
                type: "nvarchar(400)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Population",
                table: "City",
                type: "nvarchar(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "City",
                type: "nvarchar(150)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "City");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "City",
                type: "nvarchar(300)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Population",
                table: "City",
                type: "nvarchar(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldNullable: true);
        }
    }
}
