using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uyanda.CoffeeShop.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CoffeeShop");

            migrationBuilder.CreateTable(
                name: "BeverageTypes",
                schema: "CoffeeShop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeverageTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "CoffeeShop",
                table: "BeverageTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Hot" });

            migrationBuilder.InsertData(
                schema: "CoffeeShop",
                table: "BeverageTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Cold" });

            migrationBuilder.CreateIndex(
                name: "IX_BeverageTypes_Id",
                schema: "CoffeeShop",
                table: "BeverageTypes",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeverageTypes",
                schema: "CoffeeShop");
        }
    }
}
