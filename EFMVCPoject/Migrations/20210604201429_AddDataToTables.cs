using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMVCPoject.Migrations
{
    public partial class AddDataToTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "Total" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "Total" },
                values: new object[] { 2, 13 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "Total" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address", "Name", "OrderID" },
                values: new object[,]
                {
                    { 1, "Riyadh", "Saud", 1 },
                    { 2, "Jeddah", "Mohammed", 2 },
                    { 3, "Dammam", "Khalid", 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderLines",
                columns: new[] { "ID", "OrderID", "Quantity", "Subtotal" },
                values: new object[,]
                {
                    { 1, 1, 2, 30 },
                    { 2, 2, 33, 211 },
                    { 3, 3, 3, 12 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Name", "OrderLineID", "Price" },
                values: new object[] { 1, "Mouse", 1, 13 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Name", "OrderLineID", "Price" },
                values: new object[] { 2, "Keyboard", 2, 25 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Name", "OrderLineID", "Price" },
                values: new object[] { 3, "Printer", 3, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderLines",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
