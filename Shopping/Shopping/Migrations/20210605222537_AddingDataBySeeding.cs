using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class AddingDataBySeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "aalhaif@hotmail.com", "Abdullah AL Haif" },
                    { 2, "batool@gmail.com", "Batool Alghamdi" },
                    { 3, "turki@yahoo.com", "Turki Alqurashi" },
                    { 4, "ezz@gmail.com", "Abdulaziz Almohammadi" },
                    { 5, "Thamer@yahoo.com", "Thamer Mashni" },
                    { 6, "sara@hotmail.com", "Sara Alnasser" },
                    { 7, "asarawiq@outlook.com", "Abdulrahman Sarawiq" }
                });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "ID", "GiftedProduct", "Giver", "Recipient" },
                values: new object[,]
                {
                    { 4, "Beats solo3 Wireless Headphones", "Thamer Mashni", "Turki Alqurashi" },
                    { 3, "Apple TV", "Abdullaziz Almohammadi", "Thamer Mashni" },
                    { 1, "MacBook Air", "Batool Alghamdi", "Sara Alnasser" },
                    { 2, "iPad Pro", "Sara Alnasser", "Batool Alghamdi" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "brand", "image", "name", "price" },
                values: new object[,]
                {
                    { 1, "Apple", "https://images-na.ssl-images-amazon.com/images/I/71MHTD3uL4L._AC_SX679_.jpg", "iPhone 12 Pro", 4199 },
                    { 2, "Apple", "https://images-na.ssl-images-amazon.com/images/I/7118Z2RPOdL._AC_SX679_.jpg", "iPad Pro", 4249 },
                    { 3, "Apple", "https://m.media-amazon.com/images/I/71TPda7cwUL._AC_SL1500_.jpg", "MacBook Air", 4999 },
                    { 4, "Apple", "https://static.bhphoto.com/images/multiple_images/images500x500/1474305464_IMG_687773.jpg", "Beats solo3 Wireless Headphones", 820 },
                    { 5, "Apple", "https://cdn.shoplightspeed.com/shops/611777/files/17704548/1500x4000x3/apple-apple-watch-series-5-gps-44mm-gold-aluminum.jpg", "Apple Watch", 1499 },
                    { 6, "Apple", "https://images-na.ssl-images-amazon.com/images/I/51Y-Dulc3bL._AC_SX569_.jpg", "Apple TV", 949 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ID", "Price", "ServiceName" },
                values: new object[,]
                {
                    { 2, 150, "Software & Backup" },
                    { 1, 200, "Maintenance & Parts Replacement" },
                    { 3, 100, "One Year Warranty Extension" }
                });
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
                table: "Customers",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gifts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gifts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gifts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gifts",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
