using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    productImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.productImageId);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 1,
                column: "orderDate",
                value: new DateTime(2025, 6, 1, 9, 35, 25, 706, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 2,
                column: "orderDate",
                value: new DateTime(2025, 6, 1, 9, 35, 25, 706, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_productId",
                table: "ProductImages",
                column: "productId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 1,
                column: "orderDate",
                value: new DateTime(2025, 5, 24, 10, 29, 33, 147, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 2,
                column: "orderDate",
                value: new DateTime(2025, 5, 24, 10, 29, 33, 147, DateTimeKind.Local).AddTicks(6700));
        }
    }
}
