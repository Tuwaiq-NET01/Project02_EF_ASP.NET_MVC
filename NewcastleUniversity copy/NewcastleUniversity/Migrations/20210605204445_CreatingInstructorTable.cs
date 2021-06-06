using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace NewcastleUniversity.Migrations
{
    public partial class CreatingInstructorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           ;

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: false),
                    PhoneNum = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Email", "FullName", "PhoneNum", "password" },
                values: new object[] { 1, "david@uon.edu.au", "David Jack", "243212", "1258vvfdvdf" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Email", "FullName", "PhoneNum", "password" },
                values: new object[] { 2, "peter@uon.edu.au", "Peter ", "245929", "ghghgs556" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Email", "FullName", "PhoneNum", "password" },
                values: new object[] { 3, "mark@uon.edu.au", "Mark", "243956", "1258vvfdvdf" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Students_StudentId",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_StudentId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Rooms");
        }
    }
}
