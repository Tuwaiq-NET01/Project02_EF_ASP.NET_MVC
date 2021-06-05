using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Compound.Migrations
{
    public partial class Creatingm2m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users_Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
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
                        name: "FK_Users_Events_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Events_EventId",
                table: "Users_Events",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Events_UserId",
                table: "Users_Events",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users_Events");
        }
    }
}
