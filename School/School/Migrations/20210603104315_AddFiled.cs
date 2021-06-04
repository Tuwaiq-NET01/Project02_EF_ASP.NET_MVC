﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class AddFiled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "students",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "CourseId", "CourseName", "Description" },
                values: new object[] { 1, "ASP.NET", "ASP.NET with React" });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "TeacherId", "Email", "Name" },
                values: new object[] { 1, "Abduallah@Aid", "Abduallah Aid" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "StudentId", "CourseId", "Email", "Name" },
                values: new object[] { 1, 1, "Adel@Kalu", "Adel Kalu" });

            migrationBuilder.InsertData(
                table: "profiles",
                columns: new[] { "ProfileId", "City", "Country", "Image", "StudentId" },
                values: new object[] { 1, "Makkah", "Saudi Arabia", "data:image/jpeg;base64,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", 1 });

            migrationBuilder.InsertData(
                table: "studentTeachers",
                columns: new[] { "StudentTeacherId", "StudentId", "TeacherId" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "profiles",
                keyColumn: "ProfileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "studentTeachers",
                keyColumn: "StudentTeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "students",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
