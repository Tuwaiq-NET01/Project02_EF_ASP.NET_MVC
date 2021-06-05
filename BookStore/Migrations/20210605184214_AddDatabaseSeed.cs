using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class AddDatabaseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "About", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, null, "Jane", "Austen" },
                    { 2, null, "Leo", "Tolstoy" },
                    { 3, null, "Virginia", "Woolf" },
                    { 4, null, "Erich", "Gamma" },
                    { 5, null, "Richard", "Helm" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Biography" },
                    { 2, "Education" },
                    { 3, "Literature & Fiction" },
                    { 4, "History" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Penguin Random House" },
                    { 2, "Hachette Livre" },
                    { 3, "HarperCollins" },
                    { 4, "Macmillan Publishers" },
                    { 5, "Simon & Schuster" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "ISBN", "PublishedDate", "PublisherId", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, 3, "0-9594-4480-7", new DateTime(1814, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "8.7", "Northanger Abbey" },
                    { 2, 3, "0-2718-9125-4", new DateTime(1856, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "9", "War and Peace" },
                    { 3, 4, "0-1732-8402-7", new DateTime(1875, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "9", "Anna Karenina" },
                    { 4, 1, "0-2445-3536-1", new DateTime(1925, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "5", "Mrs. Dalloway" },
                    { 5, 2, "0-4540-7260-0", new DateTime(1994, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "9.2", "Design Patterns: Elements of Reusable Object-Oriented Software" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthorsModel",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 2, 3 },
                    { 4, 3, 4 },
                    { 5, 4, 5 },
                    { 6, 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthorsModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookAuthorsModel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookAuthorsModel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookAuthorsModel",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookAuthorsModel",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookAuthorsModel",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
