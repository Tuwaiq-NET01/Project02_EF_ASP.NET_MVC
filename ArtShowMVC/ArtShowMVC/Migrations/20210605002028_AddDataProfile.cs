using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShowMVC.Migrations
{
    public partial class AddDataProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "First_Name", "Gender", "Last_Name", "Phone_Number", "UserId" },
                values: new object[] { 1, "Shahad", "Female", "Alshehri", 503664482, 1 });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "First_Name", "Gender", "Last_Name", "Phone_Number", "UserId" },
                values: new object[] { 2, "Ali", "Male", "Hassan", 553388292, 2 });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "First_Name", "Gender", "Last_Name", "Phone_Number", "UserId" },
                values: new object[] { 3, "sara", "Female", "Ali", 508194230, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
