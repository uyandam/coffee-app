using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uyanda.CoffeeShop.Persistence.Migrations
{
    public partial class BeverageEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeverageEntities",
                schema: "CoffeeShop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeverageTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeverageEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeverageEntities_BeverageTypes_BeverageTypeId",
                        column: x => x.BeverageTypeId,
                        principalSchema: "CoffeeShop",
                        principalTable: "BeverageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BeverageEntities_BeverageTypeId",
                schema: "CoffeeShop",
                table: "BeverageEntities",
                column: "BeverageTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeverageEntities",
                schema: "CoffeeShop");
        }
    }
}
