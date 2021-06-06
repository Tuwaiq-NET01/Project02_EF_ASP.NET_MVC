using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalDatabase.Migrations
{
    public partial class AddedDocAndPatTablesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctor_Patient_Model",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[,]
                {
                    { 40, 1, 13 },
                    { 41, 4, 11 },
                    { 42, 3, 15 },
                    { 43, 2, 14 },
                    { 44, 2, 13 },
                    { 45, 4, 10 },
                    { 46, 5, 12 },
                    { 47, 1, 15 },
                    { 48, 3, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor_Patient_Model",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Doctor_Patient_Model",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Doctor_Patient_Model",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Doctor_Patient_Model",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Doctor_Patient_Model",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Doctor_Patient_Model",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Doctor_Patient_Model",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Doctor_Patient_Model",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Doctor_Patient_Model",
                keyColumn: "Id",
                keyValue: 48);
        }
    }
}
