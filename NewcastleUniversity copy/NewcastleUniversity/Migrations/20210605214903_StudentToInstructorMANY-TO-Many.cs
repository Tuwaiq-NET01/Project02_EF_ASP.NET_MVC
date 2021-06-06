using Microsoft.EntityFrameworkCore.Migrations;

namespace NewcastleUniversity.Migrations
{
    public partial class StudentToInstructorMANYTOMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsToInstructors",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    InstructorId = table.Column<int>(nullable: false),
                    StudentsId = table.Column<int>(nullable: true),
                    InstructorsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsToInstructors", x => new { x.StudentId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_StudentsToInstructors_Instructors_InstructorsId",
                        column: x => x.InstructorsId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsToInstructors_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsToInstructors_InstructorsId",
                table: "StudentsToInstructors",
                column: "InstructorsId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsToInstructors_StudentsId",
                table: "StudentsToInstructors",
                column: "StudentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsToInstructors");
        }
    }
}
