using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Website.Migrations
{
    public partial class relationbetweenprofileandmusic1tomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Musics",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Musics_ProfileId",
                table: "Musics",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musics_Profiles_ProfileId",
                table: "Musics",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musics_Profiles_ProfileId",
                table: "Musics");

            migrationBuilder.DropIndex(
                name: "IX_Musics_ProfileId",
                table: "Musics");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Musics");
        }
    }
}
