using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace NewcastleUniversity.Migrations
{
    public partial class AddingSeedingStudentsTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
