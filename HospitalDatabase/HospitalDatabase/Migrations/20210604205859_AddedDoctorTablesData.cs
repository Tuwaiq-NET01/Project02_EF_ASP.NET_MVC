using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalDatabase.Migrations
{
    public partial class AddedDoctorTablesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Department", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "General Medicine", "YasminG@hotmail.com", "Yasmin", "AlGhamdi", "055-569-9110" },
                    { 2, "Surgery ", "RitaF@hotmail.com", "Rita", "Farr", "050-569-9110" },
                    { 3, "Psychiatry", "TonyR@hotmail.com", "Tony", "Roberts", "054-932-6548" },
                    { 4, "General Medicine", "AmeliaO@hotmail.com", "Amelia", "Owen", "051-436-5094" },
                    { 5, "Surgery ", "KyleF@hotmail.com", "Kyle", "Fox", "059-330-4393" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
