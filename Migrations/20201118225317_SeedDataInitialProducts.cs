using Microsoft.EntityFrameworkCore.Migrations;

namespace X_Technology_ORTv2.Migrations
{
    public partial class SeedDataInitialProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "ImageUrl", "Price", "Sku", "Title" },
                values: new object[,]
                {
                    { 1, "Samsung", "Sonido", "https://www.google.com/url?sa=i&url=https%3A%2F%2Ftiendanaranja.com.py%2Ftienda-movil%2F21699-auriculares-samsung-level-on-wireless-pro-bluetooth.html&psig=AOvVaw1FI-87pR0hRpty8iNwB5Gj&ust=1605825463702000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLCDq5WUje0CFQAAAAAdAAAAABAG", 200f, "1", "Auriculares" },
                    { 2, "JBL", "Sonido", "https://d34zlyc2cp9zm7.cloudfront.net/products/7840b4935124524a1351becd203fc8ff992b1785a1ffaf8287a26aadb90953fc.jpg_1000", 160f, "3", "Parlante" },
                    { 3, "LG", "Entretenimiento", "https://http2.mlstatic.com/D_NQ_NP_2X_930556-MLA41195666242_032020-V.webp", 350f, "3", "Television" },
                    { 4, "Samsung", "Entretenimiento", "https://i1.wp.com/clipset.com/wp-content/uploads/2016/05/samsung-smart-tv.jpg?fit=916%2C600&ssl=1", 400f, "1", "Television" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
