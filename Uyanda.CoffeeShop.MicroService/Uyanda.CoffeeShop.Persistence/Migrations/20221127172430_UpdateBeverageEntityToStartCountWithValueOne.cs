using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uyanda.CoffeeShop.Persistence.Migrations
{
    public partial class UpdateBeverageEntityToStartCountWithValueOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 0);
        }
    }
}
