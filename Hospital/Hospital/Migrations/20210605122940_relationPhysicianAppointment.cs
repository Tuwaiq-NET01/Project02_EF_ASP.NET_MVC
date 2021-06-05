using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Migrations
{
    public partial class relationPhysicianAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhysicianId",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PhysicianId",
                table: "Appointments",
                column: "PhysicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Physicians_PhysicianId",
                table: "Appointments",
                column: "PhysicianId",
                principalTable: "Physicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Physicians_PhysicianId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PhysicianId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PhysicianId",
                table: "Appointments");
        }
    }
}
