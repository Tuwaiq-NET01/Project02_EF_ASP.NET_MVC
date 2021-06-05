using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    public partial class seedCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CarId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, "Lowell Doyle", "(510) 449-2589 x8809" },
                    { 2, 2, "Novella Mosciski", "763.797.3929 x25225" },
                    { 3, 3, "Filomena Hermann", "(537) 328-5617" },
                    { 4, 4, "Carley Corkery", "1-792-706-3458 x11009" },
                    { 5, 5, "Leilani Rippin", "1-583-736-8377" },
                    { 6, 6, "Esteban Nitzsche", "895.383.9579 x674" },
                    { 7, 7, "Cole Mills", "803.646.4023" },
                    { 8, 8, "Dorothea Harris", "819-723-0041 x2777" },
                    { 9, 9, "Nicola Gerlach", "921.591.2210 x793" },
                    { 10, 10, "Janet Boehm", "(934) 981-8513 x5867" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
 
        }
    }
}
