using Microsoft.EntityFrameworkCore.Migrations;

namespace Crystal_circus.Migrations
{
    public partial class InsertToPerformers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "Email", "Image", "Name", "PhoneNumber", "Profession" },
                values: new object[] { 3, null, "https://i.cbc.ca/1.5247534.1565824743!/fileImage/httpImage/image.jpg_gen/derivatives/original_780/cirque-du-soleil-luzia.jpg", "Raneen", 56738289, "Magician" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
