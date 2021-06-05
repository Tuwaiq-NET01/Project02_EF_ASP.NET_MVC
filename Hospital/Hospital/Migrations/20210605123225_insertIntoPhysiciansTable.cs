using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Migrations
{
    public partial class insertIntoPhysiciansTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Physicians",
                columns: new[] { "Id", "Name", "Position", "gender" },
                values: new object[,]
                {
                    { 1110, "Hossam", "Pediatrician", "M" },
                    { 1111, "Saad", "Internist", "M" },
                    { 1112, "John", "Peadiatric neurologist", "M" },
                    { 1113, "Eman", "Cardiologist", "F" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1113);
        }
    }
}
