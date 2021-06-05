using Microsoft.EntityFrameworkCore.Migrations;

namespace TwitterSimplified.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tweets_Users_UserId",
                table: "Tweets");

            migrationBuilder.DropIndex(
                name: "IX_Tweets_UserId",
                table: "Tweets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tweets");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Tweets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserIdId",
                table: "Tweets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tweets_UserId1",
                table: "Tweets",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tweets_UserIdId",
                table: "Tweets",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tweets_Users_UserId1",
                table: "Tweets",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tweets_Users_UserIdId",
                table: "Tweets",
                column: "UserIdId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tweets_Users_UserId1",
                table: "Tweets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tweets_Users_UserIdId",
                table: "Tweets");

            migrationBuilder.DropIndex(
                name: "IX_Tweets_UserId1",
                table: "Tweets");

            migrationBuilder.DropIndex(
                name: "IX_Tweets_UserIdId",
                table: "Tweets");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Tweets");

            migrationBuilder.DropColumn(
                name: "UserIdId",
                table: "Tweets");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tweets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tweets_UserId",
                table: "Tweets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tweets_Users_UserId",
                table: "Tweets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
