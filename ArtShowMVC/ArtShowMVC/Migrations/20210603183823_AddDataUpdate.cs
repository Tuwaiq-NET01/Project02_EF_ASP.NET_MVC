using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShowMVC.Migrations
{
    public partial class AddDataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArtsitId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArtsitId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArtsitId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArtsitId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArtsitId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArtsitId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 7,
                column: "ArtsitId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 8,
                column: "ArtsitId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 9,
                column: "ArtsitId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArtsitId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArtsitId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArtsitId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArtsitId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArtsitId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArtsitId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 7,
                column: "ArtsitId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 8,
                column: "ArtsitId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 9,
                column: "ArtsitId",
                value: 0);
        }
    }
}
