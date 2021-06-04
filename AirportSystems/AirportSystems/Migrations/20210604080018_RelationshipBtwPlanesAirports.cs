using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportSystems.Migrations
{
    public partial class RelationshipBtwPlanesAirports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Airport_ID",
                table: "Planes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AirportsAirport_ID",
                table: "Planes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Planes_AirportsAirport_ID",
                table: "Planes",
                column: "AirportsAirport_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Airports_AirportsAirport_ID",
                table: "Planes",
                column: "AirportsAirport_ID",
                principalTable: "Airports",
                principalColumn: "Airport_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Airports_AirportsAirport_ID",
                table: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Planes_AirportsAirport_ID",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "Airport_ID",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "AirportsAirport_ID",
                table: "Planes");
        }
    }
}
