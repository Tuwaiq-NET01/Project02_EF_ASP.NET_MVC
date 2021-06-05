using Microsoft.EntityFrameworkCore.Migrations;

namespace Crystal_circus.Migrations
{
    public partial class TicketandShowRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShowId",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ShowId",
                table: "Tickets",
                column: "ShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Shows_ShowId",
                table: "Tickets",
                column: "ShowId",
                principalTable: "Shows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Shows_ShowId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ShowId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ShowId",
                table: "Tickets");
        }
    }
}
