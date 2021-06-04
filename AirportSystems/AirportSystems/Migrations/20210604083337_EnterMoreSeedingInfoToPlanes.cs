using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportSystems.Migrations
{
    public partial class EnterMoreSeedingInfoToPlanes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Plane_ID", "Airport_ID", "AirportsAirport_ID", "Capacity", "Plane_Name", "Plane_Type" },
                values: new object[,]
                {
                    { 14, 4, null, 350, "Airbus 350", "Airbus" },
                    { 15, 5, null, 250, "Airbus 380", "Airbus" },
                    { 13, 3, null, 340, "Airbus 340", "Airbus" },
                    { 12, 2, null, 200, "Airbus 330", "Airbus" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Plane_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Plane_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Plane_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Plane_ID",
                keyValue: 15);
        }
    }
}
