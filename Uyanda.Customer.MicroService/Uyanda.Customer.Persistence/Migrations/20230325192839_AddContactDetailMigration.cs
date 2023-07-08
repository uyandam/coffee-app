using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uyanda.Customer.Persistence.Migrations
{
    public partial class AddContactDetailMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_ContactDetailsEntity_ContactDetailsId",
                schema: "Customer",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactDetailsEntity",
                schema: "Customer",
                table: "ContactDetailsEntity");

            migrationBuilder.RenameTable(
                name: "ContactDetailsEntity",
                schema: "Customer",
                newName: "Contacts",
                newSchema: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                schema: "Customer",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Contacts_ContactDetailsId",
                schema: "Customer",
                table: "Customers",
                column: "ContactDetailsId",
                principalSchema: "Customer",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Contacts_ContactDetailsId",
                schema: "Customer",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                schema: "Customer",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Contacts",
                schema: "Customer",
                newName: "ContactDetailsEntity",
                newSchema: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactDetailsEntity",
                schema: "Customer",
                table: "ContactDetailsEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_ContactDetailsEntity_ContactDetailsId",
                schema: "Customer",
                table: "Customers",
                column: "ContactDetailsId",
                principalSchema: "Customer",
                principalTable: "ContactDetailsEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
