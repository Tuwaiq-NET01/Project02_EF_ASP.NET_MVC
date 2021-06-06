using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace NewcastleUniversity.Migrations
{
    public partial class Edittingtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Fee = table.Column<float>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    PhoneNum = table.Column<string>(type: "text", nullable: true),
                    password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Fee", "Name" },
                values: new object[,]
                {
                    { 1, 1000f, "Digital Economy" },
                    { 2, 1900f, "Foundation of Business Analysis" },
                    { 3, 2600f, "Game Design" },
                    { 4, 1800f, "Process Analysis" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Email", "FullName", "PhoneNum", "password" },
                values: new object[,]
                {
                    { 1, "david@uon.edu.au", "David Jack", "243212", "1258vvfdvdf" },
                    { 2, "peter@uon.edu.au", "Peter ", "245929", "ghghgs556" },
                    { 3, "mark@uon.edu.au", "Mark", "243956", "1258vvfdvdf" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FullName", "password" },
                values: new object[,]
                {
                    { 1, "arwa@uon.edu.au", "Arwa Wan La", "123" },
                    { 2, "rahaf@uon.edu.au", "Rahaf Alqahtany", "wee" },
                    { 3, "rawabi@uon.edu.au", "Rawabi Alshodukhy", "qq1122ss" },
                    { 4, "samerah@uon.edu.au", "Samerah Alhusainy", "ggg775" },
                    { 5, "thuraya@uon.edu.au", "Thuraya Alzahrany", "ggd5223nnf" }
                });
        }
    }
}
