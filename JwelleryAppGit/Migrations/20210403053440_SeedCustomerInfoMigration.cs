using Microsoft.EntityFrameworkCore.Migrations;

namespace JwelleryApp.Migrations
{
    public partial class SeedCustomerInfoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerName", "CustomerType", "Password", "UserName" },
                values: new object[] { 1, "John", "Normal", "John@123", "John" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerName", "CustomerType", "Password", "UserName" },
                values: new object[] { 2, "Bob", "Privileged", "Bob@123", "Bob" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
