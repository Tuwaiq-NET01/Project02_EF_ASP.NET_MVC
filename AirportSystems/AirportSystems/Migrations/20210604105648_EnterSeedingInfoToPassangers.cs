using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportSystems.Migrations
{
    public partial class EnterSeedingInfoToPassangers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Passenger_ID", "First_Name", "Gender", "Last_Name", "Nationality", "Passport_NO", "TripID" },
                values: new object[] { 234567890, "Sou", "Male", "Hong", "Japanese", 10, 61345 });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Passenger_ID", "First_Name", "Gender", "Last_Name", "Nationality", "Passport_NO", "TripID" },
                values: new object[] { 987654321, "Zaina", "Female", "Algmosh", "Egyptian", 12, 61234 });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Passenger_ID", "First_Name", "Gender", "Last_Name", "Nationality", "Passport_NO", "TripID" },
                values: new object[] { 345678901, "Mohammed", "Male", "Alqahtani", "Saudi Arabia", 20, 61132 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Passenger_ID",
                keyValue: 234567890);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Passenger_ID",
                keyValue: 345678901);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Passenger_ID",
                keyValue: 987654321);
        }
    }
}
