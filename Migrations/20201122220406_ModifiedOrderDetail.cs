using Microsoft.EntityFrameworkCore.Migrations;

namespace X_Technology_ORTv2.Migrations
{
    public partial class ModifiedOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrdersDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_ProductId",
                table: "OrdersDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetails_Products_ProductId",
                table: "OrdersDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetails_Products_ProductId",
                table: "OrdersDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrdersDetails_ProductId",
                table: "OrdersDetails");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrdersDetails");
        }
    }
}
