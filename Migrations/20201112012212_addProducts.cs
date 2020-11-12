using Microsoft.EntityFrameworkCore.Migrations;

namespace X_Technology_ORTv2.Migrations
{
    public partial class addProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Title, Sku, Price, Brand, Category, ImageUrl) VALUES ('Matias', '1', '19', 'asd', '1', 'asd')");
            migrationBuilder.Sql("INSERT INTO Products (Title, Sku, Price, Brand, Category, ImageUrl) VALUES ('Ariel', '1', '19', 'asd', '1', 'asd')");
            migrationBuilder.Sql("INSERT INTO Products (Title, Sku, Price, Brand, Category, ImageUrl) VALUES ('Nico', '1', '19', 'asd', '1', 'asd')");
            migrationBuilder.Sql("INSERT INTO Products (Title, Sku, Price, Brand, Category, ImageUrl) VALUES ('Claudio', '1', '19', 'asd', '1', 'asd')");
            migrationBuilder.Sql("INSERT INTO Products (Title, Sku, Price, Brand, Category, ImageUrl) VALUES ('ELPepe', '1', '19', 'asd', '1', 'asd')");
            migrationBuilder.Sql("INSERT INTO Products (Title, Sku, Price, Brand, Category, ImageUrl) VALUES ('Jorge', '1', '19', 'asd', '1', 'asd')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
