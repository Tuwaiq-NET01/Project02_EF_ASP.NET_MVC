using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryStore.Migrations
{
    public partial class InsertBranchProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BranchProduct",
                columns: new[] { "BranchId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 2, 2 },
                    { 2, 3 },
                    { 1, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BranchProduct",
                keyColumns: new[] { "BranchId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BranchProduct",
                keyColumns: new[] { "BranchId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BranchProduct",
                keyColumns: new[] { "BranchId", "ProductId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BranchProduct",
                keyColumns: new[] { "BranchId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BranchProduct",
                keyColumns: new[] { "BranchId", "ProductId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BranchProduct",
                keyColumns: new[] { "BranchId", "ProductId" },
                keyValues: new object[] { 3, 2 });
        }
    }
}
