using Microsoft.EntityFrameworkCore.Migrations;

namespace Crystal_circus.Migrations
{
    public partial class InserToPerforms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "Email", "Image", "Name", "PhoneNumber", "Profession" },
                values: new object[] { 1, null, "https://www.cirquedusoleil.com/-/media/cds/images/shows/luzia/luzia-highlights/luzia_highlights_canes_1280x853.jpg?db=web&h=853&la=en&vs=1&w=1280&hash=AFCA94652F959A82CDD8D162F70A0BBE2B03813E", "Cirque du Soleil", 89357743, "Broadway" });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "Email", "Image", "Name", "PhoneNumber", "Profession" },
                values: new object[] { 2, null, "https://dynaimage.cdn.cnn.com/cnn/c_fill,g_auto,w_1200,h_675,ar_16:9/https%3A%2F%2Fcdn.cnn.com%2Fcnnnext%2Fdam%2Fassets%2F200629130029-cirque-du-soleil-bankrupt.jpg", "Reema the clown", 5628285, "Clown" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
