using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace TwitterSimplified.Migrations
{
    public partial class AddLikeRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    TweetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_Tweets_TweetId",
                        column: x => x.TweetId,
                        principalTable: "Tweets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tweets_UserId",
                table: "Tweets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_TweetId",
                table: "Likes",
                column: "TweetId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tweets_Users_UserId",
                table: "Tweets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tweets_Users_UserId",
                table: "Tweets");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Tweets_UserId",
                table: "Tweets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tweets");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Tweets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserIdId",
                table: "Tweets",
                type: "int",
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
    }
}
