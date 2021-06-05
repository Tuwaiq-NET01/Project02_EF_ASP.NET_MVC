using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Compound.Migrations
{
    public partial class SeedingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Event_Id", "Event_Date", "Event_Name", "StaffId" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Musical Event", 0 },
                    { 4, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hackthon", 0 },
                    { 5, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otaku Event", 0 }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Staff_Id", "Staff_AtWork", "Staff_Email", "Staff_Name", "Staff_PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { 1, false, "MohammadS@gmail.com", "Mohammad", "0560908070", 0 },
                    { 2, true, "JhonS@gmail.com", "Jhon", "0576855421", 0 },
                    { 5, true, "JasminS@gmail.com", "Jasmin", "0500011123", 0 }
                });

            migrationBuilder.InsertData(
                table: "Villa",
                columns: new[] { "Villa_Id", "Villa_Group", "Villa_Name", "Villa_Number" },
                values: new object[,]
                {
                    { 1, "A", "Al-Azhar", 1 },
                    { 2, "A", "Al-Khair", 2 },
                    { 3, "B", "Al-Khaliej", 3 },
                    { 4, "C", "Al-Rabea", 4 },
                    { 33, "D", "Al-Hamdanyah", 5 }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Event_Id", "Event_Date", "Event_Name", "StaffId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Musical concert", 2 },
                    { 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gamming Event", 5 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_Id", "User_Email", "User_Name", "User_PhoneNumber", "VillaId" },
                values: new object[,]
                {
                    { 1, "ControlS@gmail.com", "Abdulrahman", "0560965772", 1 },
                    { 2, "Ahmad@gmail.com", "Ahmad", "0512312345", 1 },
                    { 3, "Anas@gmail.com", "Anas", "0567324545", 1 },
                    { 4, "Sarah@gmail.com", "Sarah", "0555333642", 2 },
                    { 5, "Amjad@gmail.com", "Amjad", "0553366990", 2 }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Staff_Id", "Staff_AtWork", "Staff_Email", "Staff_Name", "Staff_PhoneNumber", "UserId" },
                values: new object[] { 3, true, "AliceS@gmail.com", "Alice", "0567431473", 3 });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Staff_Id", "Staff_AtWork", "Staff_Email", "Staff_Name", "Staff_PhoneNumber", "UserId" },
                values: new object[] { 4, true, "TonyS@gmail.com", "Tony", "0576524582", 3 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Service_Id", "Service_Name", "StaffId" },
                values: new object[,]
                {
                    { 3, "InVilla Service", 3 },
                    { 4, "Massage", 3 },
                    { 5, "Whatever", 3 },
                    { 1, "Clean the swimming pool", 4 },
                    { 2, "Preparing the basketball ground play", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Event_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Event_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Event_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Event_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Event_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Service_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Service_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Service_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Service_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Service_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 1);
        }
    }
}
