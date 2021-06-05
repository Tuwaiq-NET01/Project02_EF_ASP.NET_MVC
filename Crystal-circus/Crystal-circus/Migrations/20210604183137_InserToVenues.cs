using Microsoft.EntityFrameworkCore.Migrations;

namespace Crystal_circus.Migrations
{
    public partial class InserToVenues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Address", "Image", "Type" },
                values: new object[] { 1, "Zag, Hanover, Germany", "https://www.eventim.de/obj/media/DE-eventim/teaser/artworks/2019/young-stage-int-circus-festival-tickets-artwork-2020.jpg", "Arena" });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Address", "Image", "Type" },
                values: new object[] { 2, "QUARTERBACK Immobilien, Leipzig, Germany", "https://www.quarterback-immobilien-arena.de/fileadmin/files/_processed_/7/2/csm_03_Tempete_The_Fall-4404_Credit_Cirque_du_Soleil_44bc978214.jpg", "Arena" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
