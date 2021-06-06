using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalDatabase.Migrations
{
    public partial class AddedMedicationTableData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "Brand", "Name" },
                values: new object[,]
                {
                    { 30, "Sanofi-Aventis", "Lantus Solostar" },
                    { 31, "Otsuka", "Abilify" },
                    { 32, "GlaxoSmithKline", "Advair Diskus" },
                    { 33, "Pfizer", "Lyrica" },
                    { 34, "Merck", "Januvia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 34);
        }
    }
}
