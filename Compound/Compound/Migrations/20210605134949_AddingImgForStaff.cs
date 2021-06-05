using Microsoft.EntityFrameworkCore.Migrations;

namespace Compound.Migrations
{
    public partial class AddingImgForStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Staff_Img",
                table: "Staff",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 1,
                column: "Staff_Img",
                value: "https://content.api.news/v3/images/bin/7b790c831c72c5dd3b3275833df09f29");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 2,
                column: "Staff_Img",
                value: "https://cdn-0.generatormix.com/images/anime-character/death-the-kid.jpg");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 3,
                column: "Staff_Img",
                value: "https://animerantshome.files.wordpress.com/2019/08/istj-anime-characters-akame-ga-kill.png?w=600");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 4,
                column: "Staff_Img",
                value: "https://static.fandomspot.com/images/11/10193/00-featured-killua-zoldyck-hunter-x-hunter-anime-preview.jpg");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 5,
                column: "Staff_Img",
                value: "https://vignette.wikia.nocookie.net/akamegakill/images/6/62/Jaegers5.png/revision/latest?cb=20150720195115&path-prefix=ru");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Staff_Img",
                table: "Staff");
        }
    }
}
