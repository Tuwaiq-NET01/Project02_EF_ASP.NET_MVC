using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Migrations
{
    public partial class insertIntoAppointmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "ID", "Date_Time", "PatientId", "PhysicianId" },
                values: new object[] { 772, "10-12-2021 09:30AM", 1124398, 1110 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "ID", "Date_Time", "PatientId", "PhysicianId" },
                values: new object[] { 733, "03-09-2021 10:00AM", 1683398, 1113 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 772);
        }
    }
}
