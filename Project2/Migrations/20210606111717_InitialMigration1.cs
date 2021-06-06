using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class InitialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharacterStatus_StatusId",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharacterStatus_StatusId",
                table: "Characters",
                column: "StatusId",
                principalTable: "CharacterStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharacterStatus_StatusId",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharacterStatus_StatusId",
                table: "Characters",
                column: "StatusId",
                principalTable: "CharacterStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
