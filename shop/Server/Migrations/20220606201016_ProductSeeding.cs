using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "987654321", "https://cattalesinc.org/wp-content/uploads/slider2/DSC_0029-2048x1360.jpeg", 10.0m, "rubiks" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "123456789", "https://cattalesinc.org/wp-content/uploads/slider2/DSC_0029-2048x1360.jpeg", 100.0m, "kubiks" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "147852369", "https://cattalesinc.org/wp-content/uploads/slider2/DSC_0029-2048x1360.jpeg", 75.0m, "rubiks kubiks" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
