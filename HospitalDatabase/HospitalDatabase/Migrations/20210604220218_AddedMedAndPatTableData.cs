using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalDatabase.Migrations
{
    public partial class AddedMedAndPatTableData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medication_Patient_Model",
                columns: new[] { "Id", "MedicationId", "PatientId" },
                values: new object[,]
                {
                    { 50, 30, 13 },
                    { 51, 34, 11 },
                    { 52, 31, 15 },
                    { 53, 32, 14 },
                    { 54, 32, 13 },
                    { 55, 34, 10 },
                    { 56, 33, 12 },
                    { 57, 30, 15 },
                    { 58, 31, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medication_Patient_Model",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Medication_Patient_Model",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Medication_Patient_Model",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Medication_Patient_Model",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Medication_Patient_Model",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Medication_Patient_Model",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Medication_Patient_Model",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Medication_Patient_Model",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Medication_Patient_Model",
                keyColumn: "Id",
                keyValue: 58);
        }
    }
}
