using Microsoft.EntityFrameworkCore.Migrations;

namespace TwitterSimplified.Migrations
{
    public partial class SeedingTables : Migration
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

            migrationBuilder.InsertData(
                table: "Tweets",
                columns: new[] { "Id", "Content", "UserId1", "UserIdId" },
                values: new object[,]
                {
                    { 1, "The first tweet!", null, null },
                    { 2, "The second tweet!", null, null },
                    { 3, "The third tweet!", null, null },
                    { 4, "The fourth tweet!", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "bigboss@twitterify.com", "nopass", "BigBoss" },
                    { 2, "smallboss@twitterify.com", "futureBigboss", "SmallBoss" }
                });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "TweetId", "UserId" },
                values: new object[,]
                {
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 1, 1, 2 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Bio", "UserId" },
                values: new object[,]
                {
                    { 1, "Contributing to this futuristic platform", 1 },
                    { 2, "Hard working", 2 }
                });

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

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tweets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

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
