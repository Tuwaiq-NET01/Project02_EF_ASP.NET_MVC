using Microsoft.EntityFrameworkCore.Migrations;

namespace PlayerReview.Migrations
{
    public partial class SEEDINGgameANDcompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName", "Logo" },
                values: new object[,]
                {
                    { 1, "Treyarch", "https://yt3.ggpht.com/ytc/AAUvwnh8dnAnPVNQQqjVbu0FSHFcc2-V0y_v4N738TR-9Q=s900-c-k-c0x00ffffff-no-rj" },
                    { 2, "Rockstar", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Rockstar_Games_Logo.svg/1200px-Rockstar_Games_Logo.svg.png" },
                    { 3, "Activision", "https://lh3.googleusercontent.com/proxy/gLOIG6uMP6dvK3deO3DSW21R4KwuNbKrgI1XF2OQlUrYkiR_IK0gYHAdoPxHDUYC3OW9JfR1RO_BbtuxUpNB_XVwOZX18xhv-eMHC3iC_UO6RsEm_zM_dxd7QS299vo" },
                    { 4, "Gurilla Games", "https://upload.wikimedia.org/wikipedia/en/thumb/1/17/Guerrilla_logo.svg/1200px-Guerrilla_logo.svg.png" },
                    { 5, "Ghost Games", "https://seeklogo.com/images/G/ghost-games-logo-8F6060DF77-seeklogo.com.png" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CompanyId", "Description", "GameName", "Genre", "Image" },
                values: new object[,]
                {
                    { 3, 1, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", "Black Ops", null, "https://cdn.europosters.eu/image/750/posters/call-of-duty-black-ops-cover-i8700.jpg" },
                    { 2, 1, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", "Modern Warfare", null, "https://m.media-amazon.com/images/M/MV5BMTc3NWY2ZTMtNTNlZC00MWM2LWI5MzYtMmU1YzY0ODk5ZjQ1XkEyXkFqcGdeQXVyODA2MTkwODk@._V1_.jpg" },
                    { 1, 2, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", "Grand Theft Auto", null, "https://media.rockstargames.com/rockstargames/img/global/news/upload/actual_1421419184.jpg" },
                    { 4, 3, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", "Crash Bandicoot", null, "https://cdn.europosters.eu/image/750/posters/crash-bandicoot-4-ride-i99518.jpg" },
                    { 5, 4, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", "Horizon", null, "https://cdn.europosters.eu/image/750/posters/horizon-zero-dawn-key-art-i34856.jpg" },
                    { 6, 5, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", "Need for Speed", null, "https://lh3.googleusercontent.com/proxy/Xb1jfc8iI2vPhYM_N2kvbmCjQIyYc0n6RX2wBGT-MhbXjB63DygrF2vIlyi_3jxajbHsPy9-6u3fPRmadwTWktwEB0ypGLcxjb3O0FWSUt7FFG8ykhJQJiXMj3lmizjSS-tYEIjHy7g" },
                    { 7, 5, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", "Need for Speed Heat", null, "https://posterspy.com/wp-content/uploads/2019/12/46a85b70014089.5d717791b29ac.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
