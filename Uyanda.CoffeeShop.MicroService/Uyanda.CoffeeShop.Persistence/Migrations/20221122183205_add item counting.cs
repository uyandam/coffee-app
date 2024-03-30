using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uyanda.CoffeeShop.Persistence.Migrations
{
    public partial class additemcounting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                schema: "CoffeeShop",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                schema: "CoffeeShop",
                table: "Beverages");
        }
    }
}
