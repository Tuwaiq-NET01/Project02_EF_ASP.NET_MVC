using Microsoft.EntityFrameworkCore.Migrations;

namespace furnitureStore.Migrations
{
    public partial class AddMoreSeeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, "Dammam", "Fatma.Alqhtnay94@hotmail.com", "Fatimah", "Alqhtnay", 555906886 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
