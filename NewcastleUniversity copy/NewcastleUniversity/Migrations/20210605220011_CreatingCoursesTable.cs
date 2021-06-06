using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace NewcastleUniversity.Migrations
{
    public partial class CreatingCoursesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CodeNum = table.Column<string>(nullable: false),
                    Fee = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CodeNum", "Fee", "Name" },
                values: new object[,]
                {
                    { 1, "INFT6060", 1000.0, "Digital Economy" },
                    { 2, "GSBS6002", 1900.0, "Foundation of Business Analysis" },
                    { 3, "INFT6300", 2600.0, "Game Design" },
                    { 4, "INFO6050", 1800.0, "Process Analysis" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
