using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class productImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "productImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 1,
                column: "productImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 2,
                column: "productImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 3,
                column: "productImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 4,
                column: "productImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 5,
                column: "productImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 6,
                column: "productImageUrl",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productImageUrl",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 1,
                column: "orderDate",
                value: new DateTime(2025, 5, 4, 11, 10, 48, 201, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 2,
                column: "orderDate",
                value: new DateTime(2025, 5, 4, 11, 10, 48, 201, DateTimeKind.Local).AddTicks(5600));
        }
    }
}
