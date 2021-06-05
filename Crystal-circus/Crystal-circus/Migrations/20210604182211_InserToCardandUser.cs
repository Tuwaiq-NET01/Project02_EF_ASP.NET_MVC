using Microsoft.EntityFrameworkCore.Migrations;

namespace Crystal_circus.Migrations
{
    public partial class InserToCardandUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Creditcards",
                columns: new[] { "Id", "CVCNumber", "CardNumber", "Date", "HolderName" },
                values: new object[] { 1, 178, 518674827, "07/23", "hanan" });

            migrationBuilder.InsertData(
                table: "Creditcards",
                columns: new[] { "Id", "CVCNumber", "CardNumber", "Date", "HolderName" },
                values: new object[] { 2, 602, 518624197, "11/21", "areej" });

            migrationBuilder.InsertData(
                table: "Creditcards",
                columns: new[] { "Id", "CVCNumber", "CardNumber", "Date", "HolderName" },
                values: new object[] { 3, 402, 518602356, "03/22", "aryam" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreditcardId", "Email", "Name", "PhoneNumber" },
                values: new object[] { 1, 1, "han@example.com", "hanan", 5539572 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreditcardId", "Email", "Name", "PhoneNumber" },
                values: new object[] { 2, 2, "ali@example.com", "ali", 5012372 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreditcardId", "Email", "Name", "PhoneNumber" },
                values: new object[] { 3, 3, "lay@example.com", "layla", 5645339 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Creditcards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Creditcards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Creditcards",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
