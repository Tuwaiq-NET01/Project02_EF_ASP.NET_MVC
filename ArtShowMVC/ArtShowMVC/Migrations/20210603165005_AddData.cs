using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShowMVC.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ArtWorks",
                columns: new[] { "Id", "ArtsitId", "ArtsitsModelId", "Image", "Price", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 0, null, "https://arabartforsale.com/uploads/artworks/1621526489_file.jpeg", 350, "African Girl", 0 },
                    { 2, 0, null, "https://i.pinimg.com/564x/19/75/d6/1975d6e559da17936176eb6168161089.jpg", 400, "Beach Girl", 0 },
                    { 3, 0, null, "https://i.pinimg.com/564x/b5/97/59/b597595d747bde7c979c9e4a37e2c674.jpg", 450, "Health Heroes", 0 },
                    { 4, 0, null, "https://i.pinimg.com/564x/ef/6b/11/ef6b11c49ea530a0420252f6defb8904.jpg", 500, "Peace", 0 },
                    { 5, 0, null, "https://i.pinimg.com/564x/16/e4/64/16e464c0cab9851c52eed6688889bc25.jpg", 550, "Mditate Look", 0 },
                    { 6, 0, null, "https://i.pinimg.com/564x/0d/e5/54/0de554e7bdb9b876fd7a7138c70cdb2c.jpg", 600, "Playing Music", 0 },
                    { 7, 0, null, " https://i.pinimg.com/564x/da/b4/83/dab483b7b0e472a8777ab008bb06dba3.jpg", 650, "Look Of Hope", 0 },
                    { 8, 0, null, "https://i.pinimg.com/564x/b6/97/25/b6972560735a5eccba28aab8cf37dd92.jpg", 700, "Flower Girl", 0 },
                    { 9, 0, null, "https://i.pinimg.com/474x/24/f9/54/24f9540c894b2756ff42dc0f8dbf2f76.jpg", 750, "Playing Music", 0 }
                });

            migrationBuilder.InsertData(
                table: "Artsits",
                columns: new[] { "Id", "Name", "NumberPhone" },
                values: new object[,]
                {
                    { 1, "Mousa Fahad ", 553478768 },
                    { 2, " Afnan Ali", 50754676 },
                    { 3, "Amal Alshehri", 557779835 },
                    { 4, "Hassan Khiled", 53769487 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "0987", "shahad123" },
                    { 2, "1234", "ali123" },
                    { 3, "5678", "sara123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artsits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artsits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artsits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artsits",
                keyColumn: "Id",
                keyValue: 4);

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
        }
    }
}
