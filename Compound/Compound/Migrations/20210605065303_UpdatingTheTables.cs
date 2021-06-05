using Microsoft.EntityFrameworkCore.Migrations;

namespace Compound.Migrations
{
    public partial class UpdatingTheTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User_Email",
                table: "Users",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "User_PhoneNumber",
                table: "Users",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Staff_Email",
                table: "Staff",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Staff_PhoneNumber",
                table: "Staff",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "User_PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Staff_Email",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Staff_PhoneNumber",
                table: "Staff");
        }
    }
}
