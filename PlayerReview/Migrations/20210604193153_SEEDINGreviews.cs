using Microsoft.EntityFrameworkCore.Migrations;

namespace PlayerReview.Migrations
{
    public partial class SEEDINGreviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "GameId", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", 3, "Great Game!" },
                    { 2, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", 4, "Extremely fun Game!" },
                    { 3, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", 5, "Amazing Visuals!" },
                    { 4, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", 6, "Not that good..." },
                    { 5, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", 6, "Boring." },
                    { 6, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", 3, "Very good." },
                    { 7, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", 7, "Great Game!" },
                    { 8, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor", 1, "Great Game!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
