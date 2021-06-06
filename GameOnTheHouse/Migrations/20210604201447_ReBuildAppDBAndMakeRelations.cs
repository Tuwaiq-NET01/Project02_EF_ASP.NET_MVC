using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace GameOnTheHouse.Migrations
{
    public partial class ReBuildAppDBAndMakeRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserAccounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameDetailId",
                table: "Screenshots",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GameUrl",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "GameDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FavoriteGames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteGames_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_UserId",
                table: "UserAccounts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Screenshots_GameDetailId",
                table: "Screenshots",
                column: "GameDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_GameDetails_GameId",
                table: "GameDetails",
                column: "GameId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteGames_GameId",
                table: "FavoriteGames",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteGames_UserId",
                table: "FavoriteGames",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameDetails_Games_GameId",
                table: "GameDetails",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenshots_GameDetails_GameDetailId",
                table: "Screenshots",
                column: "GameDetailId",
                principalTable: "GameDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccounts_Users_UserId",
                table: "UserAccounts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameDetails_Games_GameId",
                table: "GameDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenshots_GameDetails_GameDetailId",
                table: "Screenshots");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAccounts_Users_UserId",
                table: "UserAccounts");

            migrationBuilder.DropTable(
                name: "FavoriteGames");

            migrationBuilder.DropIndex(
                name: "IX_UserAccounts_UserId",
                table: "UserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_Screenshots_GameDetailId",
                table: "Screenshots");

            migrationBuilder.DropIndex(
                name: "IX_GameDetails_GameId",
                table: "GameDetails");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "GameDetailId",
                table: "Screenshots");

            migrationBuilder.DropColumn(
                name: "GameUrl",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "GameDetails");
        }
    }
}
