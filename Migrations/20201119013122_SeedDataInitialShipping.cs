using Microsoft.EntityFrameworkCore.Migrations;

namespace X_Technology_ORTv2.Migrations
{
    public partial class SeedDataInitialShipping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shippings",
                columns: new[] { "Id", "Address", "City", "ExtraInformation", "Firstname", "Lastname", "Province", "ZipCode" },
                values: new object[,]
                {
                    { 1, "yatay", "Buenos Aires", null, "Jorge", "Serrano", null, "1000" },
                    { 2, "yatay", "Buenos Aires", null, "Matias", "Olivera", null, "1000" },
                    { 3, "yatay", "Buenos Aires", null, "Ariel", "Bonfil", null, "1000" },
                    { 4, "yatay", "Buenos Aires", null, "Nicolas", "Altman", null, "1000" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
