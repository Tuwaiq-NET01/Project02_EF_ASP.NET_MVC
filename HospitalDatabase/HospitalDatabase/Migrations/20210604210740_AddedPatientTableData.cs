using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalDatabase.Migrations
{
    public partial class AddedPatientTableData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 10, "AlexiaP@hotmail.com", "Alexia", "Perry", "055-099-4432" },
                    { 11, "PenelopeR@hotmail.com", "Penelope", "Ray", "054-090-5326" },
                    { 12, "NoahR@hotmail.com", "Noah", "Roberts", "053-675-4490" },
                    { 13, "LukeL@hotmail.com", "Luke", "Luna", "055-546-3210" },
                    { 14, "TimothyR@hotmail.com", "Timothy", "Riley", "053-556-7432" },
                    { 15, "BellaH@hotmail.com", "Bella", "Holt", "058-903-8953" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
