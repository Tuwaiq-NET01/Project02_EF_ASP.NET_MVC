using Microsoft.EntityFrameworkCore.Migrations;

namespace Crystal_circus.Migrations
{
    public partial class Relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Time", "VenueId" },
                values: new object[] { 1, "Sep 22-26, 2021", 2 });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Time", "VenueId" },
                values: new object[] { 2, "Aug 16, 2021", 1 });

            migrationBuilder.InsertData(
                table: "ShowPerformerModel",
                columns: new[] { "Id", "PerformerId", "ShowId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ShowId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 3, 1, 2 },
                    { 2, 2, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShowPerformerModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShowPerformerModel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
