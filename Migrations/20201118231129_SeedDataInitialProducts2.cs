using Microsoft.EntityFrameworkCore.Migrations;

namespace X_Technology_ORTv2.Migrations
{
    public partial class SeedDataInitialProducts2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://dummyimage.com/600x400/000/fff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Ftiendanaranja.com.py%2Ftienda-movil%2F21699-auriculares-samsung-level-on-wireless-pro-bluetooth.html&psig=AOvVaw1FI-87pR0hRpty8iNwB5Gj&ust=1605825463702000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLCDq5WUje0CFQAAAAAdAAAAABAG");
        }
    }
}
