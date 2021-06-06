using Microsoft.EntityFrameworkCore.Migrations;

namespace TripWebsite.Migrations
{
    public partial class OneToManyBtweenTouristsTableAndScheduledToursTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TouristId",
                table: "ScheduledTours",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledTours_TouristId",
                table: "ScheduledTours",
                column: "TouristId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledTours_Tourists_TouristId",
                table: "ScheduledTours",
                column: "TouristId",
                principalTable: "Tourists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledTours_Tourists_TouristId",
                table: "ScheduledTours");

            migrationBuilder.DropIndex(
                name: "IX_ScheduledTours_TouristId",
                table: "ScheduledTours");

            migrationBuilder.DropColumn(
                name: "TouristId",
                table: "ScheduledTours");
        }
    }
}
