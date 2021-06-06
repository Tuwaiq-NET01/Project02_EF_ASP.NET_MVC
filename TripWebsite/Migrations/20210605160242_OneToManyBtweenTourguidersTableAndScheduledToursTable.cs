using Microsoft.EntityFrameworkCore.Migrations;

namespace TripWebsite.Migrations
{
    public partial class OneToManyBtweenTourguidersTableAndScheduledToursTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TourguiderId",
                table: "ScheduledTours",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledTours_TourguiderId",
                table: "ScheduledTours",
                column: "TourguiderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledTours_Tourguiders_TourguiderId",
                table: "ScheduledTours",
                column: "TourguiderId",
                principalTable: "Tourguiders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledTours_Tourguiders_TourguiderId",
                table: "ScheduledTours");

            migrationBuilder.DropIndex(
                name: "IX_ScheduledTours_TourguiderId",
                table: "ScheduledTours");

            migrationBuilder.DropColumn(
                name: "TourguiderId",
                table: "ScheduledTours");
        }
    }
}
