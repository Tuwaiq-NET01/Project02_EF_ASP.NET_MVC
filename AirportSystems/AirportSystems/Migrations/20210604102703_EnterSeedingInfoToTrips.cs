using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportSystems.Migrations
{
    public partial class EnterSeedingInfoToTrips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripID", "Cabin_Class", "Destination", "Duration", "Price", "Road_Type", "Take_Off_Time", "Trip_Type", "Weight" },
                values: new object[,]
                {
                    { 61132, "guest", "dammam", 3, 457, "one-way", 22, "Internal", 30 },
                    { 61234, "first", "LA-USA", 10, 7939, "one-way", 23, "international", 50 },
                    { 61345, "guest", "Turkey", 13, 4211, "round-trip", 0, "international", 40 },
                    { 61456, "guest", "NewYork-USA", 14, 5689, "round-trip", 19, "international", 40 },
                    { 61567, "guest", "Bali", 11, 2945, "one-way", 2, "international", 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripID",
                keyValue: 61132);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripID",
                keyValue: 61234);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripID",
                keyValue: 61345);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripID",
                keyValue: 61456);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripID",
                keyValue: 61567);
        }
    }
}
