using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGallery.Migrations
{
    public partial class ArtistsDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtId", "ArtBio", "ArtImg", "ArtName" },
                values: new object[] { 1, "Originally from a small town in the south of Italy Angelo Accardi moved to Napoli to study fine arts at the Art Academy of Naples. Shortly after, in the early 90s, he set up his personal studio close to his childhood home to embark on his pursuit of painting and sculpture. In the course of his artistic development, Accardi has been on a constant search for new sensations using mixed media to depictfigures against differing social backgrounds.", "https://www.angeloaccardi.com/wp-content/uploads/sites/11/2017/12/acardi-620x620-home.jpg", "Angelo Accardi" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtId", "ArtBio", "ArtImg", "ArtName" },
                values: new object[] { 2, "Trained and educated as an artist in the south of France, Benharrouche went on to become a distinguished professor of drawing and painting at Nice´s Academie Paganini. His influences include masters such as Chagall, Picasso, and Miro, yet Benharrouche’s personal style comes through in each of his compositions with much strength, balance and harmony. Deeply spiritual, Yoel Benharrouche establishes a sincere connection with his audience. His vibrant palette and mystical contemplation explore both the historical and spiritual world of Israel. He paints his surroundings with a lyrical quality that has landed him among the elite artists of the world, exploring the duality between the material and the mystical world.", "https://www.eden-gallery.com/wp-content/uploads/sites/15/2017/09/yoel-benharrouche-at-the-studio-105-1-683x1024.jpg", "Benharrouche" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtId", "ArtBio", "ArtImg", "ArtName" },
                values: new object[] { 3, "Born in California in 1965, Tommy studied art history at Santa Monica College in the United States, later on, studying architecture and interior design. His passion for aesthetics drove Tommy to dabble in different fields of design, like high-end furniture and silversmith work, eventually evolving into a painter and artist. Over the years, Tommy became an upscale interior designer, designing projects for high-end clientele.", "https://d2vg5otv6yjmj3.cloudfront.net/wp-content/uploads/2015/12/tommy.jpg", "Tommy Shenkar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtId",
                keyValue: 3);
        }
    }
}
