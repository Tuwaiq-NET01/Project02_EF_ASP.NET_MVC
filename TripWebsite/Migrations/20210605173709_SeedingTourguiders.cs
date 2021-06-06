using Microsoft.EntityFrameworkCore.Migrations;

namespace TripWebsite.Migrations
{
    public partial class SeedingTourguiders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tourguiders",
                columns: new[] { "Id", "About", "DestinationId", "Email", "Img", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Omar work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.", 1, null, "https://images.unsplash.com/photo-1496302662116-35cc4f36df92?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1650&q=80", "Omar", 559898987 },
                    { 2, "Sallah work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.", 2, null, "https://images.unsplash.com/photo-1493863641943-9b68992a8d07?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjZ8fHBlcnNvbnxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", "Sallah", 987644444 },
                    { 3, "Mona work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.", 3, null, "https://images.unsplash.com/photo-1534126506432-a0173ba75bf6?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1650&q=80", "Mona", 542122222 },
                    { 4, "Khalid work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.", 4, null, "https://images.unsplash.com/photo-1491555103944-7c647fd857e6?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1650&q=80", "khalid", 558888990 },
                    { 5, "sara work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.", 5, null, "https://images.unsplash.com/photo-1603983616619-faf118d6c374?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1650&q=80", "sara", 558811111 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tourguiders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tourguiders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tourguiders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tourguiders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tourguiders",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
