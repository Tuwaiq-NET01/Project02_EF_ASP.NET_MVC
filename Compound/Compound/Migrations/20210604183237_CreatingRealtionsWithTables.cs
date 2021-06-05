using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Compound.Migrations
{
    public partial class CreatingRealtionsWithTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Staff_AtWork",
                table: "Staff",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Staff",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Services",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users_Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    UsertId = table.Column<int>(nullable: false),
                    User_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Events_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Event_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Events_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_VillaId",
                table: "Users",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_UserId",
                table: "Staff",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_StaffId",
                table: "Services",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_StaffId",
                table: "Events",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Events_EventId",
                table: "Users_Events",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Events_User_Id",
                table: "Users_Events",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Staff_StaffId",
                table: "Events",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Staff_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Staff_StaffId",
                table: "Services",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Staff_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Users_UserId",
                table: "Staff",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Villa_VillaId",
                table: "Users",
                column: "VillaId",
                principalTable: "Villa",
                principalColumn: "Villa_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Staff_StaffId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Staff_StaffId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Users_UserId",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Villa_VillaId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Users_Events");

            migrationBuilder.DropIndex(
                name: "IX_Users_VillaId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Staff_UserId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Services_StaffId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Events_StaffId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "VillaId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Staff_AtWork",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Events");
        }
    }
}
