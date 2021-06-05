using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace TuwaiqDatabase.Migrations
{
    public partial class FirstMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bootcamps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bootcamps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    BootcampId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Expertise = table.Column<string>(type: "text", nullable: true),
                    JoinDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
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
                    Name = table.Column<string>(type: "text", nullable: true),
                    Bootcamp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bootcamps",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET Bootcamp", new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), ".Alef Bootcamp", new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "BootcampId", "EndTime", "InstructorId", "Name", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 6, 5, 13, 15, 30, 0, DateTimeKind.Unspecified), 0, ".NET MVC", new DateTime(2021, 6, 5, 10, 15, 30, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2021, 6, 5, 17, 15, 30, 0, DateTimeKind.Unspecified), 0, "React", new DateTime(2021, 6, 5, 14, 15, 30, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2021, 6, 6, 17, 15, 30, 0, DateTimeKind.Unspecified), 0, "Design Patterns", new DateTime(2021, 6, 6, 14, 15, 30, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2021, 6, 7, 17, 15, 30, 0, DateTimeKind.Unspecified), 0, "Unit Testing", new DateTime(2021, 6, 7, 14, 15, 30, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2021, 6, 4, 17, 15, 30, 0, DateTimeKind.Unspecified), 0, "Graphic Engines", new DateTime(2021, 6, 4, 14, 15, 30, 0, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(2021, 6, 5, 17, 15, 30, 0, DateTimeKind.Unspecified), 0, "Unity", new DateTime(2021, 6, 5, 14, 15, 30, 0, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(2021, 6, 6, 17, 15, 30, 0, DateTimeKind.Unspecified), 0, "Pixel Art", new DateTime(2021, 6, 6, 14, 15, 30, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "ClassId", "Expertise", "JoinDate", "Name" },
                values: new object[,]
                {
                    { 6, 4, "Unit Testing", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nouf" },
                    { 5, 7, "Android", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lamya" },
                    { 4, 6, "iOS", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah" },
                    { 2, 2, "Java", new DateTime(2019, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mishal" },
                    { 1, 1, "C", new DateTime(2018, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdullah" },
                    { 3, 3, "Design Patterns", new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norah" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Bootcamp", "Name" },
                values: new object[,]
                {
                    { 5, 1, "Maha" },
                    { 1, 1, "Khalid" },
                    { 2, 1, "Mohammed" },
                    { 3, 1, "Abdulrahman" },
                    { 4, 1, "Nawal" },
                    { 6, 1, "Joharah" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bootcamps");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
