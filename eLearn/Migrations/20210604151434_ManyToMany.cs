using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace eLearn.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Lecturer",
                table: "User_Lecturer");

            migrationBuilder.DropIndex(
                name: "IX_User_Lecturer_UserId",
                table: "User_Lecturer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Course",
                table: "User_Course");

            migrationBuilder.DropIndex(
                name: "IX_User_Course_UserId",
                table: "User_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lecturer_Course",
                table: "Lecturer_Course");

            migrationBuilder.DropIndex(
                name: "IX_Lecturer_Course_LecturerId",
                table: "Lecturer_Course");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "User_Lecturer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "User_Course",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Lecturer_Course",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Lecturer",
                table: "User_Lecturer",
                columns: new[] { "UserId", "LecturerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Course",
                table: "User_Course",
                columns: new[] { "UserId", "CourseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lecturer_Course",
                table: "Lecturer_Course",
                columns: new[] { "LecturerId", "CourseId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Lecturer",
                table: "User_Lecturer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Course",
                table: "User_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lecturer_Course",
                table: "Lecturer_Course");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "User_Lecturer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "User_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Lecturer_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Lecturer",
                table: "User_Lecturer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Course",
                table: "User_Course",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lecturer_Course",
                table: "Lecturer_Course",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Lecturer_UserId",
                table: "User_Lecturer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Course_UserId",
                table: "User_Course",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturer_Course_LecturerId",
                table: "Lecturer_Course",
                column: "LecturerId");
        }
    }
}
