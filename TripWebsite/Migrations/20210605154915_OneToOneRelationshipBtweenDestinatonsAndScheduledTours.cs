using Microsoft.EntityFrameworkCore.Migrations;

namespace TripWebsite.Migrations
{
    public partial class OneToOneRelationshipBtweenDestinatonsAndScheduledTours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DestinationBriefInformation",
                table: "ScheduledTours",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationDate",
                table: "ScheduledTours",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "ScheduledTours",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DestinationImg",
                table: "ScheduledTours",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationName",
                table: "ScheduledTours",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DestinationPrice",
                table: "ScheduledTours",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledTours_DestinationId",
                table: "ScheduledTours",
                column: "DestinationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledTours_Destinations_DestinationId",
                table: "ScheduledTours",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledTours_Destinations_DestinationId",
                table: "ScheduledTours");

            migrationBuilder.DropIndex(
                name: "IX_ScheduledTours_DestinationId",
                table: "ScheduledTours");

            migrationBuilder.DropColumn(
                name: "DestinationBriefInformation",
                table: "ScheduledTours");

            migrationBuilder.DropColumn(
                name: "DestinationDate",
                table: "ScheduledTours");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "ScheduledTours");

            migrationBuilder.DropColumn(
                name: "DestinationImg",
                table: "ScheduledTours");

            migrationBuilder.DropColumn(
                name: "DestinationName",
                table: "ScheduledTours");

            migrationBuilder.DropColumn(
                name: "DestinationPrice",
                table: "ScheduledTours");
        }
    }
}
