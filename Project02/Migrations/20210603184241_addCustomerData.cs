using Microsoft.EntityFrameworkCore.Migrations;

namespace Project01.Migrations
{
    public partial class addCustomerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Email", "Name", "Password", "PhoneNumber" },
                values: new object[] { 1, "Fahad ALarifi Street", "Hail", "rawabe44u@gmail.com", "Rawabe", "123456", "0560396778" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Email", "Name", "Password", "PhoneNumber" },
                values: new object[] { 2, "Ahmed ALarifi Street", "Abha", "rahaf@gmail.com", "Rahaf", "123456", "0560396878" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Email", "Name", "Password", "PhoneNumber" },
                values: new object[] { 3, "Younis ALarifi Street", "Dammam", "reema@gmail.com", "Reema", "999", "0560396798" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
