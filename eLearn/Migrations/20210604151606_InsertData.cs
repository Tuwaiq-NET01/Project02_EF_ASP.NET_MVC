using Microsoft.EntityFrameworkCore.Migrations;

namespace eLearn.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Know more about  science", "https://cdn.kastatic.org/genfiles/topic-icons/icons/chemistry.png-8540e8-128c.png", "Science" },
                    { 2, "Know more about computer programming", "https://cdn.kastatic.org/genfiles/topic-icons/icons/programming.png-e13016-128c.png", "Computer programming" }
                });

            migrationBuilder.InsertData(
                table: "Lecturer",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Amal@gmail.com", "Bader", "alqahtani" },
                    { 2, "Sami@gmail.com", "Sami", "Alshammari" },
                    { 3, "Ahad@gmail.com", "Ahad", "Alghamdi" },
                    { 4, "Amal@gmail.com", "Rami", "Alshehri " },
                    { 5, "Sami@gmail.com", "Fahad", "Alshammari" },
                    { 6, "Ahad@gmail.com", "Nora", "Alghamdi" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Amal@gmail.com", "Amal", "Almutairi" },
                    { 2, "Lama@gmail.com", "Lama", "Alsalman" },
                    { 3, "Reema@gmail.com", "Reema", "Altwaim" },
                    { 4, "Sultan@gmail.com", "Sultan", "Alsalman" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CategoryId", "CourseDescription", "CourseImage", "CourseLevel", "CourseName" },
                values: new object[,]
                {
                    { 1, 1, "Unit: Introduction to electrical engineering", "https://cdn.kastatic.org/genfiles/topic-icons/icons/electrical_engineering.png-da92ce-128c.png", "Beginner", "Electrical Engineering" },
                    { 2, 1, "Unit: Scale of the universe", "https://cdn.kastatic.org/genfiles/topic-icons/icons/electrical_engineering.png-da92ce-128c.png", "Beginner", "Biology" },
                    { 3, 1, "Unit: Scale of the universe", "https://cdn.kastatic.org/genfiles/topic-icons/icons/electrical_engineering.png-da92ce-128c.png", "Intermediate", "Cosmology and astronomy" },
                    { 4, 1, "Unit: IAtoms, compounds, and ions", "https://cdn.kastatic.org/genfiles/topic-icons/icons/atom.png-e81d05-128c.png", "Advanced", "Chemistry" },
                    { 5, 2, "Unit: Intro to HTML/CSS: Making webpages", "https://cdn.kastatic.org/genfiles/topic-icons/icons/programming.png-e13016-128c.png", "Beginner", "HTML/CSS: Making webpages" },
                    { 6, 2, "Unit: Intro to SQL: Querying and managing data", "https://cdn.kastatic.org/genfiles/topic-icons/icons/databases.png-776f54-128c.png", "Beginner", "Querying and managing data" },
                    { 7, 2, "Unit: HTML/JS: Making webpages interactive", "https://cdn.kastatic.org/genfiles/topic-icons/icons/markup.png-8a1e75-128c.png", "Intermediate", "HTML/JS webpages interactive" },
                    { 8, 2, "Unit: Advanced JS: Natural Simulations", "https://cdn.kastatic.org/genfiles/topic-icons/icons/programming.png-e13016-128c.png", "Advanced", "JS: Natural Simulations" }
                });

            migrationBuilder.InsertData(
                table: "User_Lecturer",
                columns: new[] { "UserId", "LecturerId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 3, 2 },
                    { 2, 5, 3 },
                    { 2, 4, 4 },
                    { 3, 4, 5 },
                    { 3, 6, 6 },
                    { 4, 5, 7 },
                    { 4, 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "Lecturer_Course",
                columns: new[] { "LecturerId", "CourseId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 2, 3 },
                    { 6, 7, 9 },
                    { 4, 3, 6 },
                    { 4, 4, 4 },
                    { 5, 4, 7 },
                    { 5, 8, 8 },
                    { 4, 5, 5 },
                    { 2, 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "User_Course",
                columns: new[] { "UserId", "CourseId", "Id" },
                values: new object[,]
                {
                    { 3, 7, 6 },
                    { 4, 6, 8 },
                    { 2, 4, 3 },
                    { 2, 3, 4 },
                    { 1, 2, 2 },
                    { 1, 1, 1 },
                    { 3, 5, 5 },
                    { 4, 8, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lecturer_Course",
                keyColumns: new[] { "LecturerId", "CourseId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Lecturer_Course",
                keyColumns: new[] { "LecturerId", "CourseId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Lecturer_Course",
                keyColumns: new[] { "LecturerId", "CourseId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Lecturer_Course",
                keyColumns: new[] { "LecturerId", "CourseId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Lecturer_Course",
                keyColumns: new[] { "LecturerId", "CourseId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Lecturer_Course",
                keyColumns: new[] { "LecturerId", "CourseId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Lecturer_Course",
                keyColumns: new[] { "LecturerId", "CourseId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Lecturer_Course",
                keyColumns: new[] { "LecturerId", "CourseId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "Lecturer_Course",
                keyColumns: new[] { "LecturerId", "CourseId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "User_Course",
                keyColumns: new[] { "UserId", "CourseId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "User_Course",
                keyColumns: new[] { "UserId", "CourseId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "User_Course",
                keyColumns: new[] { "UserId", "CourseId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "User_Course",
                keyColumns: new[] { "UserId", "CourseId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "User_Course",
                keyColumns: new[] { "UserId", "CourseId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "User_Course",
                keyColumns: new[] { "UserId", "CourseId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "User_Course",
                keyColumns: new[] { "UserId", "CourseId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "User_Course",
                keyColumns: new[] { "UserId", "CourseId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "User_Lecturer",
                keyColumns: new[] { "UserId", "LecturerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "User_Lecturer",
                keyColumns: new[] { "UserId", "LecturerId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "User_Lecturer",
                keyColumns: new[] { "UserId", "LecturerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "User_Lecturer",
                keyColumns: new[] { "UserId", "LecturerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "User_Lecturer",
                keyColumns: new[] { "UserId", "LecturerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "User_Lecturer",
                keyColumns: new[] { "UserId", "LecturerId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "User_Lecturer",
                keyColumns: new[] { "UserId", "LecturerId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "User_Lecturer",
                keyColumns: new[] { "UserId", "LecturerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lecturer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lecturer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lecturer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lecturer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lecturer",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lecturer",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
