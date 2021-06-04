using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportSystems.Migrations
{
    public partial class TheRelationshipbtweenPlaneAndTrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Plane_ID",
                table: "Trips",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Plane_ID1",
                table: "Trips",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_Plane_ID1",
                table: "Trips",
                column: "Plane_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Planes_Plane_ID1",
                table: "Trips",
                column: "Plane_ID1",
                principalTable: "Planes",
                principalColumn: "Plane_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Planes_Plane_ID1",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_Plane_ID1",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "Plane_ID",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "Plane_ID1",
                table: "Trips");
        }
    }
}
