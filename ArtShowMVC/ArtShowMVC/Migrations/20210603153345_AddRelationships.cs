using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShowMVC.Migrations
{
    public partial class AddRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Profile",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArtsitId",
                table: "ArtWorks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArtsitsModelId",
                table: "ArtWorks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ArtWorks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserId",
                table: "Profile",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_ArtsitId",
                table: "ArtWorks",
                column: "ArtsitId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_ArtsitsModelId",
                table: "ArtWorks",
                column: "ArtsitsModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_UserId",
                table: "ArtWorks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtWorks_ArtWorks_ArtsitId",
                table: "ArtWorks",
                column: "ArtsitId",
                principalTable: "ArtWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtWorks_Artsits_ArtsitsModelId",
                table: "ArtWorks",
                column: "ArtsitsModelId",
                principalTable: "Artsits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtWorks_Users_UserId",
                table: "ArtWorks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Users_UserId",
                table: "Profile",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtWorks_ArtWorks_ArtsitId",
                table: "ArtWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtWorks_Artsits_ArtsitsModelId",
                table: "ArtWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtWorks_Users_UserId",
                table: "ArtWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Users_UserId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_UserId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_ArtWorks_ArtsitId",
                table: "ArtWorks");

            migrationBuilder.DropIndex(
                name: "IX_ArtWorks_ArtsitsModelId",
                table: "ArtWorks");

            migrationBuilder.DropIndex(
                name: "IX_ArtWorks_UserId",
                table: "ArtWorks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "ArtsitId",
                table: "ArtWorks");

            migrationBuilder.DropColumn(
                name: "ArtsitsModelId",
                table: "ArtWorks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ArtWorks");
        }
    }
}
