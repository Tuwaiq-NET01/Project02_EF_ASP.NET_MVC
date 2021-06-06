using Microsoft.EntityFrameworkCore.Migrations;

namespace NewcastleUniversity.Migrations
{
    public partial class SeedingStudentsTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FullName", "password" },
                values: new object[,]
                {
                    { 1, "arwa@uon.edu.au", "Arwa Wan La", "123" },
                    { 2, "rahaf@uon.edu.au", "Rahaf Alqahtany", "wee" },
                    { 3, "rawabi@uon.edu.au", "Rawabi Alshodukhy", "qq1122ss" },
                    { 4, "samerah@uon.edu.au", "Samerah Alhusainy", "ggg775" },
                    { 5, "thuraya@uon.edu.au", "Thuraya Alzahrany", "ggd5223nnf" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
