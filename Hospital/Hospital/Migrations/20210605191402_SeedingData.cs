using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name", "PhysicianId" },
                values: new object[,]
                {
                    { 44, "Emergency", 1113 },
                    { 20, "Neonatal", 1112 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "NationalID", "Address", "Gender", "Name" },
                values: new object[,]
                {
                    { 1775342, "Alqadsiah", "M", "Battal" },
                    { 1883547, "Narjes", "M", "Mohhamad" },
                    { 1354922, "Qurtubah", "F", "Fai" },
                    { 1820336, "Alsalman", "F", "Salwa" },
                    { 1837354, "Alaziziah", "F", "Lamees" }
                });

            migrationBuilder.InsertData(
                table: "Physicians",
                columns: new[] { "Id", "Name", "Position", "gender" },
                values: new object[,]
                {
                    { 1119, "Sara", "Psychiatrist", "F" },
                    { 1117, "Hana", "Surgeon", "F" },
                    { 1144, "Jason", "Dermatologist", "M" },
                    { 1180, "Abrar", "Internist", "F" },
                    { 1151, "Derek", "Surgeon", "M" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "ID", "Date_Time", "PatientId", "PhysicianId" },
                values: new object[,]
                {
                    { 886, "19-10-2021 01:00PM", 1775342, 1111 },
                    { 992, "09-02-2021 08:00AM", 1837354, 1119 },
                    { 338, "11-07-2021 09:45AM", 1354922, 1180 },
                    { 177, "20-11-2021 12:00PM", 1992755, 1180 },
                    { 334, "30-05-2021 10:35AM", 1820336, 1151 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name", "PhysicianId" },
                values: new object[] { 90, "Anesthetics", 1151 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1883547);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1354922);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1775342);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1820336);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1837354);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1180);
        }
    }
}
