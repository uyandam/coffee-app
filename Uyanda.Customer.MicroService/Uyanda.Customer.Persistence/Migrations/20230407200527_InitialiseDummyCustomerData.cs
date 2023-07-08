using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uyanda.Customer.Persistence.Migrations
{
    public partial class InitialiseDummyCustomerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Customer",
                table: "Contacts",
                columns: new[] { "Id", "EmailAddress", "PhoneNumber" },
                values: new object[] { 1, "dummyemail@example.com", "0720000111" });

            migrationBuilder.InsertData(
                schema: "Customer",
                table: "Customers",
                columns: new[] { "Id", "ContactDetailsId", "Name", "Points", "Surname" },
                values: new object[] { 1, 1, "The Rza", 5, "The Gza" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Customer",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Customer",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
