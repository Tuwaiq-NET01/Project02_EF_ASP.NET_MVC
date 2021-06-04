using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace AirportSystems.Migrations
{
    public partial class CreateTripsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Trip_Type = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Take_Off_Time = table.Column<int>(nullable: false),
                    Cabin_Class = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    Road_Type = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    Destination = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
