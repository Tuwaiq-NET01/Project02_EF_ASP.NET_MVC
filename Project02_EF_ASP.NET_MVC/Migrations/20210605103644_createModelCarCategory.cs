using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class createModelCarCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AddColumn<int>(
                name: "CarCategoryID",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarCategories_CategoryId",
                table: "Cars",
                column: "CategoryId",
                principalTable: "CarCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarCategories_CategoryId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "CarCategories");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarCategoryID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CarId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, "Lowell Doyle", "(510) 449-2589 x8809" },
                    { 2, 2, "Novella Mosciski", "763.797.3929 x25225" },
                    { 3, 3, "Filomena Hermann", "(537) 328-5617" },
                    { 4, 4, "Carley Corkery", "1-792-706-3458 x11009" },
                    { 5, 5, "Leilani Rippin", "1-583-736-8377" },
                    { 6, 6, "Esteban Nitzsche", "895.383.9579 x674" },
                    { 7, 7, "Cole Mills", "803.646.4023" },
                    { 8, 8, "Dorothea Harris", "819-723-0041 x2777" },
                    { 9, 9, "Nicola Gerlach", "921.591.2210 x793" },
                    { 10, 10, "Janet Boehm", "(934) 981-8513 x5867" }
                });
        }
    }
}
