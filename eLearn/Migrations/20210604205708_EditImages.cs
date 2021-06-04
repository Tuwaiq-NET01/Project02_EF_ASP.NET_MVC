using Microsoft.EntityFrameworkCore.Migrations;

namespace eLearn.Migrations
{
    public partial class EditImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseImage",
                value: "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseImage",
                value: "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseImage", "CourseName" },
                values: new object[] { "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg", "Cosmology " });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseImage",
                value: "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                column: "CourseImage",
                value: "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                column: "CourseImage",
                value: "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                column: "CourseImage",
                value: "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                column: "CourseImage",
                value: "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseImage",
                value: "https://cdn.kastatic.org/genfiles/topic-icons/icons/electrical_engineering.png-da92ce-128c.png");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseImage",
                value: "https://cdn.kastatic.org/genfiles/topic-icons/icons/electrical_engineering.png-da92ce-128c.png");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseImage", "CourseName" },
                values: new object[] { "https://cdn.kastatic.org/genfiles/topic-icons/icons/electrical_engineering.png-da92ce-128c.png", "Cosmology and astronomy" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseImage",
                value: "https://cdn.kastatic.org/genfiles/topic-icons/icons/atom.png-e81d05-128c.png");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                column: "CourseImage",
                value: "https://cdn.kastatic.org/genfiles/topic-icons/icons/programming.png-e13016-128c.png");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                column: "CourseImage",
                value: "https://cdn.kastatic.org/genfiles/topic-icons/icons/databases.png-776f54-128c.png");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                column: "CourseImage",
                value: "https://cdn.kastatic.org/genfiles/topic-icons/icons/markup.png-8a1e75-128c.png");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                column: "CourseImage",
                value: "https://cdn.kastatic.org/genfiles/topic-icons/icons/programming.png-e13016-128c.png");
        }
    }
}
