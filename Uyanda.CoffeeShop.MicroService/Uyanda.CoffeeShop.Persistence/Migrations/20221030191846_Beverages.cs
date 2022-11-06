using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uyanda.CoffeeShop.Persistence.Migrations
{
    public partial class Beverages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeverageEntities_BeverageTypes_BeverageTypeId",
                schema: "CoffeeShop",
                table: "BeverageEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BeverageEntities",
                schema: "CoffeeShop",
                table: "BeverageEntities");

            migrationBuilder.RenameTable(
                name: "BeverageEntities",
                schema: "CoffeeShop",
                newName: "Beverages",
                newSchema: "CoffeeShop");

            migrationBuilder.RenameIndex(
                name: "IX_BeverageEntities_BeverageTypeId",
                schema: "CoffeeShop",
                table: "Beverages",
                newName: "IX_Beverages_BeverageTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beverages",
                schema: "CoffeeShop",
                table: "Beverages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Beverages_BeverageTypes_BeverageTypeId",
                schema: "CoffeeShop",
                table: "Beverages",
                column: "BeverageTypeId",
                principalSchema: "CoffeeShop",
                principalTable: "BeverageTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beverages_BeverageTypes_BeverageTypeId",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beverages",
                schema: "CoffeeShop",
                table: "Beverages");

            migrationBuilder.RenameTable(
                name: "Beverages",
                schema: "CoffeeShop",
                newName: "BeverageEntities",
                newSchema: "CoffeeShop");

            migrationBuilder.RenameIndex(
                name: "IX_Beverages_BeverageTypeId",
                schema: "CoffeeShop",
                table: "BeverageEntities",
                newName: "IX_BeverageEntities_BeverageTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BeverageEntities",
                schema: "CoffeeShop",
                table: "BeverageEntities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BeverageEntities_BeverageTypes_BeverageTypeId",
                schema: "CoffeeShop",
                table: "BeverageEntities",
                column: "BeverageTypeId",
                principalSchema: "CoffeeShop",
                principalTable: "BeverageTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
