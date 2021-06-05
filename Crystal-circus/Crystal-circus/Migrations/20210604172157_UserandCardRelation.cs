using Microsoft.EntityFrameworkCore.Migrations;

namespace Crystal_circus.Migrations
{
    public partial class UserandCardRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreditcardId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreditcardId",
                table: "Users",
                column: "CreditcardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Creditcards_CreditcardId",
                table: "Users",
                column: "CreditcardId",
                principalTable: "Creditcards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Creditcards_CreditcardId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CreditcardId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreditcardId",
                table: "Users");
        }
    }
}
