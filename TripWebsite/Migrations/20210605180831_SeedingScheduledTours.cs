using Microsoft.EntityFrameworkCore.Migrations;

namespace TripWebsite.Migrations
{
    public partial class SeedingScheduledTours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ScheduledTours",
                columns: new[] { "Id", "DestinationBriefInformation", "DestinationDate", "DestinationId", "DestinationImg", "DestinationName", "DestinationPrice", "TourguiderId", "TouristId" },
                values: new object[,]
                {
                    { 1, "Downtown ST Paul MN", "021-06-08", 1, "https://images.unsplash.com/photo-1594872653896-21c0b452d605?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1650&q=80", "Downtown", 400m, 1, 1 },
                    { 2, "Lake Paul MN", "2021-03-16", 2, "https://images.unsplash.com/photo-1606836131166-5cb137786a8d?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTR8fHRvdXJ8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", "Lake", 350m, 1, 1 },
                    { 3, "Oldtown Paul MN", "2021-07-01", 3, "https://images.unsplash.com/photo-1467269204594-9661b134dd2b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDN8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=800&q=60", "Oldtown", 400m, 2, 4 },
                    { 4, "Museum Paul MN", "2021-06-14", 4, "https://images.unsplash.com/photo-1618604440689-d5465097c6a0?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fG11c3VlbXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", "Museum", 350m, 3, 2 },
                    { 5, "wilds Paul MN", "2021-06-24", 5, "https://images.unsplash.com/photo-1586016413664-864c0dd76f53?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NDB8fHRvdXJ8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", "wilds", 300m, 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScheduledTours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ScheduledTours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ScheduledTours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ScheduledTours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ScheduledTours",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
