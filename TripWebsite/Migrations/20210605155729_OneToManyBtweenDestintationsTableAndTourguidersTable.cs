using Microsoft.EntityFrameworkCore.Migrations;

namespace TripWebsite.Migrations
{
    public partial class OneToManyBtweenDestintationsTableAndTourguidersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "Tourguiders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tourguiders_DestinationId",
                table: "Tourguiders",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tourguiders_Destinations_DestinationId",
                table: "Tourguiders",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tourguiders_Destinations_DestinationId",
                table: "Tourguiders");

            migrationBuilder.DropIndex(
                name: "IX_Tourguiders_DestinationId",
                table: "Tourguiders");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Tourguiders");
        }
    }
}
