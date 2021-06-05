using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Compound.Migrations
{
    public partial class ChangeTheNameOfCompoundToVilla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compound");

            migrationBuilder.CreateTable(
                name: "Villa",
                columns: table => new
                {
                    Villa_Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Villa_Name = table.Column<string>(nullable: true),
                    Villa_Group = table.Column<string>(nullable: true),
                    Villa_Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villa", x => x.Villa_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villa");

            migrationBuilder.CreateTable(
                name: "Compound",
                columns: table => new
                {
                    Compound_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Compound_Group = table.Column<string>(type: "text", nullable: true),
                    Compound_Name = table.Column<string>(type: "text", nullable: true),
                    Compound_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compound", x => x.Compound_Id);
                });
        }
    }
}
