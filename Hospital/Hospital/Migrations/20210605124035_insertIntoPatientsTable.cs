using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Migrations
{
    public partial class insertIntoPatientsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "NationalID", "Address", "Gender", "Name" },
                values: new object[,]
                {
                    { 1122998, "Almoroj", "F", "Sara" },
                    { 1124398, "Almoroj", "F", "Lama" },
                    { 1683398, "Olia", "M", "Saud" },
                    { 1992755, "Alworod", "M", "Fares" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1122998);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1124398);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1683398);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1992755);
        }
    }
}
