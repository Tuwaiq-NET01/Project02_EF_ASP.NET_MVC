using Microsoft.EntityFrameworkCore.Migrations;

namespace CatAdoption.Migrations
{
    public partial class SeedingCatAndLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "vaccination",
                table: "cat",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "age",
                table: "cat",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "cat",
                columns: new[] { "id", "AdopterId", "LocationId", "OwnerId", "age", "breed", "description", "gender", "image", "name", "vaccination" },
                values: new object[,]
                {
                    { 2, 0, 2, 0, "young", " Bengal", " They are named Beauregaurd and Antoine. They are the smartest cats I have ever interacted with and and know words and love one another deeply. They are loving yet independent and will play for hours on end with either myself or another. I have an enclosed outdoor space they love to hang out in.", "male", "https://pet-uploads.adoptapet.com/8/b/9/546264169.jpg", "Antoine and Beauregaurd", true },
                    { 3, 0, 3, 0, "young", "Domestic Shorthair", "Meet the ever-glamorous Elizabeth Taylor.she's 10 months old, like most celebrities, she’s reclusive and prefers a quiet environment. Elizabeth is also very shy and will require someone with patience. However, she is not shy when it’s time for cat treats! Elizabeth is a strict pescatarian, enjoying the finest fish and seafood. She also enjoys living her best life playing with her favorite toy balls. This exquisite girl has the most beautiful markings with a black whip-like tail and bangs. She is a glamorous girl and is looking for her up upscale forever home.", "female", "https://pet-uploads.adoptapet.com/8/8/f/442558865.jpg", "Elizabeth Taylor", true }
                });

            migrationBuilder.InsertData(
                table: "location",
                columns: new[] { "id", "address", "name", "phone" },
                values: new object[,]
                {
                    { 4, "202 broadway st", "walmart", " 657474384 " },
                    { 5, "102 broadway st", "Pet", " 7548484844 " },
                    { 6, "30 broadway st", "kittycat", " 8545499504 " }
                });

            migrationBuilder.InsertData(
                table: "cat",
                columns: new[] { "id", "AdopterId", "LocationId", "OwnerId", "age", "breed", "description", "gender", "image", "name", "vaccination" },
                values: new object[] { 4, 0, 4, 0, "Adult", "Domestic Shorthair", "Nyx is a 3 years black domestic short hair cat. She is a very loving cat when she gets comfortable around you. Nyx loves playing with stuffed mice, but mainly loves lounging around the house. She is always by the door when I come home and will come say goodbye when I have to leave. She will be a bit shy at first until she gets comfortable with her surroundings. She originally was rescued from a very sad situation where she was not taken care of properly. She will require a home that is quiet and low key, and a person that will be patient with her and allow her to get used to new surroundings. Nyx has so much love to give- will you give her that chance?", "female", "https://pet-uploads.adoptapet.com/2/9/5/516563701.jpg", "Nyx", true });

            migrationBuilder.InsertData(
                table: "cat",
                columns: new[] { "id", "AdopterId", "LocationId", "OwnerId", "age", "breed", "description", "gender", "image", "name", "vaccination" },
                values: new object[] { 5, 0, 5, 0, "young", "Domestic Shorthair", "Hello there! I’m Pepper, nice to meet ya!I'm 10 months old I’m a wee sweet sleepy boy looking for my tender and loving FUREVER home! One of my nicknames is Dr. Pepper! I have a doctorate in adorable from Major Cuties University. Not to brag but I graduated at the top of my class! The black smudge on my nose and spotted coat are how I got my name. My smudge and my cute little overbite are my most precious features; but I have too many to count them all. I’m quite a handsome kitten! I’m really excited to live with other kitties and maybe even a doggy! My foster home is full of furbabies- cats of all ages and even a dog! I’m well adjusted, and brave around new people!", "male", "https://pet-uploads.adoptapet.com/e/5/a/536736979.jpg", "Pepper", true });

            migrationBuilder.InsertData(
                table: "cat",
                columns: new[] { "id", "AdopterId", "LocationId", "OwnerId", "age", "breed", "description", "gender", "image", "name", "vaccination" },
                values: new object[] { 6, 0, 6, 0, "Adult", "Domestic Shorthair", "Gracie Mae is a 5 years sweet and confident girl--very adventurous and brave! She's bonded to her sister, Hope, and the two ladies will be 4 years old in May 2020. Gracie Mae loves to explore and play. She also loves to cuddle A LOT. She is a talkative young lady and really enjoys affection. She may be shy with new people, but once she settles in, she's a lovebug.", "female", "https://pet-uploads.adoptapet.com/7/9/6/477702221.jpg", "Mae", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cat",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "cat",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "cat",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "cat",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "cat",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "vaccination",
                table: "cat",
                type: "text",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "age",
                table: "cat",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
