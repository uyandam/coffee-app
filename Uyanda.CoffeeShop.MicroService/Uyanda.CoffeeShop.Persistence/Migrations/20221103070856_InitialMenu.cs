using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uyanda.CoffeeShop.Persistence.Migrations
{
    public partial class InitialMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.AddColumn<int>(
                name: "BeverageNameId",
                schema: "CoffeeShop",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BeverageSizeId",
                schema: "CoffeeShop",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BeverageNames",
                schema: "CoffeeShop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeverageNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BeverageSizes",
                schema: "CoffeeShop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeverageSizes", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "CoffeeShop",
                table: "BeverageNames",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Coffee" },
                    { 2, "Five Roses" },
                    { 3, "Milkshake" }
                });

            migrationBuilder.InsertData(
                schema: "CoffeeShop",
                table: "BeverageSizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Small" },
                    { 2, "Medium" },
                    { 3, "Large" }
                });

            migrationBuilder.InsertData(
                schema: "CoffeeShop",
                table: "Beverages",
                columns: new[] { "Id", "BeverageNameId", "BeverageSizeId", "BeverageTypeId", "Price" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 15m },
                    { 2, 2, 1, 1, 25m },
                    { 3, 3, 1, 2, 30m },
                    { 4, 1, 2, 1, 10m },
                    { 5, 2, 2, 1, 15m },
                    { 6, 3, 2, 2, 20m },
                    { 7, 1, 3, 1, 20m },
                    { 8, 2, 3, 1, 30m },
                    { 9, 3, 3, 2, 40m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beverages_BeverageNameId",
                schema: "CoffeeShop",
                table: "Beverages",
                column: "BeverageNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Beverages_BeverageSizeId",
                schema: "CoffeeShop",
                table: "Beverages",
                column: "BeverageSizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beverages_BeverageNames_BeverageNameId",
                schema: "CoffeeShop",
                table: "Beverages",
                column: "BeverageNameId",
                principalSchema: "CoffeeShop",
                principalTable: "BeverageNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Beverages_BeverageSizes_BeverageSizeId",
                schema: "CoffeeShop",
                table: "Beverages",
                column: "BeverageSizeId",
                principalSchema: "CoffeeShop",
                principalTable: "BeverageSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beverages_BeverageNames_BeverageNameId",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.DropForeignKey(
                name: "FK_Beverages_BeverageSizes_BeverageSizeId",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.DropTable(
                name: "BeverageNames",
                schema: "CoffeeShop");

            migrationBuilder.DropTable(
                name: "BeverageSizes",
                schema: "CoffeeShop");

            migrationBuilder.DropIndex(
                name: "IX_Beverages_BeverageNameId",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.DropIndex(
                name: "IX_Beverages_BeverageSizeId",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "CoffeeShop",
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "BeverageNameId",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.DropColumn(
                name: "BeverageSizeId",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "CoffeeShop",
                table: "Beverages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
