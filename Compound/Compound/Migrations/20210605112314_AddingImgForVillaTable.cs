using Microsoft.EntityFrameworkCore.Migrations;

namespace Compound.Migrations
{
    public partial class AddingImgForVillaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Villa_Img",
                table: "Villa",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 1,
                column: "Villa_Img",
                value: "https://q-xx.bstatic.com/images/hotel/max1024x768/163/163300408.jpg");

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 2,
                column: "Villa_Img",
                value: "https://cf.bstatic.com/images/hotel/max1024x768/256/256451213.jpg");

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 3,
                column: "Villa_Img",
                value: "https://assets.entrepreneur.com/content/3x2/2000/1604135072-webaliser--TPTXZd9mOo-unsplash.jpg");

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 4,
                column: "Villa_Img",
                value: "https://images.traum-ferienwohnungen.de/277125/8501414/46/villa-blanka.jpg");

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 33,
                column: "Villa_Img",
                value: "https://images.traum-ferienwohnungen.de/266108/7923121/46/villa-1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Villa_Img",
                table: "Villa");
        }
    }
}
