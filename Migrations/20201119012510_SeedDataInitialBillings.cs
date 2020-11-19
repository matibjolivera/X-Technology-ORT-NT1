using Microsoft.EntityFrameworkCore.Migrations;

namespace X_Technology_ORTv2.Migrations
{
    public partial class SeedDataInitialBillings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Billings",
                columns: new[] { "Id", "Document", "Email", "Firstname", "Lastname" },
                values: new object[] { 1, "12345678", "pepito@yahoo.com.ar", "Pepe", "Rodriguez" });

            migrationBuilder.InsertData(
                table: "Billings",
                columns: new[] { "Id", "Document", "Email", "Firstname", "Lastname" },
                values: new object[] { 2, "12345679", "salo@gmail.com.ar", "Salomon", "R" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Billings",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
