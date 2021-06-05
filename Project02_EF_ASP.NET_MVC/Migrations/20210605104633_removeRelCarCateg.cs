using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class removeRelCarCateg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarCategories_CategoryId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CarCategoryID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Cars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarCategoryID",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Electric" });

            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Gasoline" });

            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Diesel" });

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
    }
}
