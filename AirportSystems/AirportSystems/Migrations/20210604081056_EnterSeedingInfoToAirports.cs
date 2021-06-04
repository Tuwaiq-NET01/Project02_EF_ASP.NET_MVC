using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportSystems.Migrations
{
    public partial class EnterSeedingInfoToAirports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Airport_Short",
                table: "Airports",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 5);

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Airport_ID", "Airport_Name", "Airport_Short", "Country_City", "Gate" },
                values: new object[] { 1, "ALAIN INTERNATIONAL AIRPORT", "ANN", "emirates", "G11" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Airport_ID",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Airport_Short",
                table: "Airports",
                type: "int",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldNullable: true);
        }
    }
}
