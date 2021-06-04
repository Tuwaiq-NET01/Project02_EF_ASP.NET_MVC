using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportSystems.Migrations
{
    public partial class EnterSeedingInfoToPlanes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Plane_ID", "Airport_ID", "AirportsAirport_ID", "Capacity", "Plane_Name", "Plane_Type" },
                values: new object[] { 11, 1, null, 500, "Airbus A300 / A310", "Airbus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Plane_ID",
                keyValue: 11);
        }
    }
}
