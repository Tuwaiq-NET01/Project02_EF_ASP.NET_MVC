using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportSystems.Migrations
{
    public partial class EnterMoreSeedingInfoToAirports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Airport_ID", "Airport_Name", "Airport_Short", "Country_City", "Gate" },
                values: new object[,]
                {
                    { 2, "KING HUSSAIN INTERNATIONAL AIRPORT", "AQJ", "JURDAN", "G107" },
                    { 3, "ABUDAHABI INTERNATIONAL AIRPORT", "AUH", "emirates", "G07" },
                    { 4, "BAHRAIN INTERNATIONAL AIRPORT", "BAH", "bahrain", "G34" },
                    { 5, "KING FAHD INTERNATIONAL AIRPORT", "DMM", "dammam", "G2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Airport_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Airport_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Airport_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Airport_ID",
                keyValue: 5);
        }
    }
}
