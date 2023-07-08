using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uyanda.CoffeeShop.Persistence.Migrations
{
    public partial class PricesEntityModelBuilder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.AddColumn<int>(
                name: "PriceId",
                schema: "CoffeeShop",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                schema: "CoffeeShop",
                table: "Prices",
                columns: new[] { "Id", "Currency", "Price" },
                values: new object[,]
                {
                    { 1, "ZAR", 15m },
                    { 2, "ZAR", 25m },
                    { 3, "ZAR", 30m },
                    { 4, "ZAR", 10m },
                    { 5, "ZAR", 15m },
                    { 6, "ZAR", 20m },
                    { 7, "ZAR", 20m },
                    { 8, "ZAR", 30m },
                    { 9, "ZAR", 40m }
                });

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "PriceId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "PriceId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "PriceId",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "PriceId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 5,
                column: "PriceId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 6,
                column: "PriceId",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 7,
                column: "PriceId",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 8,
                column: "PriceId",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 9,
                column: "PriceId",
                value: 9);

            migrationBuilder.CreateIndex(
                name: "IX_Beverages_PriceId",
                schema: "CoffeeShop",
                table: "Beverages",
                column: "PriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beverages_Prices_PriceId",
                schema: "CoffeeShop",
                table: "Beverages",
                column: "PriceId",
                principalSchema: "CoffeeShop",
                principalTable: "Prices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beverages_Prices_PriceId",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.DropIndex(
                name: "IX_Beverages_PriceId",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Prices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Prices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Prices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Prices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Prices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Prices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "PriceId",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                schema: "CoffeeShop",
                table: "Beverages",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 15m);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 25m);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 30m);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 15m);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 20m);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 20m);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 30m);

            migrationBuilder.UpdateData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 40m);
        }
    }
}
