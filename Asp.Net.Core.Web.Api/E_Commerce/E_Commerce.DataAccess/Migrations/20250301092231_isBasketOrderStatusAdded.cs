using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Commerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class isBasketOrderStatusAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "orderStatusId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "basketStatusId",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BasketStatuses",
                columns: table => new
                {
                    basketStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    basketStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketStatuses", x => x.basketStatusId);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    orderStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.orderStatusId);
                });

            migrationBuilder.InsertData(
                table: "BasketStatuses",
                columns: new[] { "basketStatusId", "basketStatusName" },
                values: new object[,]
                {
                    { 1, "Sepet Aktif" },
                    { 2, "Sepet İptal" },
                    { 3, "Sepet Siparişe İletildi" }
                });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "basketId",
                keyValue: 1,
                columns: new[] { "basketStatusId", "userId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "basketId",
                keyValue: 2,
                columns: new[] { "basketStatusId", "userId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "orderStatusId", "orderStatusName" },
                values: new object[,]
                {
                    { 1, "Sipariş Aktif" },
                    { 2, "Sipariş İptal" },
                    { 3, "Sipariş Tamamlandı" }
                });

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "basketId", "basketStatusId", "userId" },
                values: new object[] { 3, 3, 4 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "orderId", "basketId", "orderDate", "orderStatusId", "totalAmount", "userId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 3, 1, 12, 22, 31, 426, DateTimeKind.Local).AddTicks(7920), 3, 400, 2 },
                    { 2, 2, new DateTime(2025, 3, 1, 12, 22, 31, 426, DateTimeKind.Local).AddTicks(7960), 3, 850, 4 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "orderDetailId", "orderId", "order_product_quantity", "order_product_totalPrice", "productId" },
                values: new object[,]
                {
                    { 1, 1, 2, 400, 1 },
                    { 2, 1, 1, 150, 3 },
                    { 3, 2, 1, 350, 4 },
                    { 4, 2, 1, 650, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_orderStatusId",
                table: "Orders",
                column: "orderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_basketStatusId",
                table: "Baskets",
                column: "basketStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_BasketStatuses_basketStatusId",
                table: "Baskets",
                column: "basketStatusId",
                principalTable: "BasketStatuses",
                principalColumn: "basketStatusId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_orderStatusId",
                table: "Orders",
                column: "orderStatusId",
                principalTable: "OrderStatuses",
                principalColumn: "orderStatusId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_BasketStatuses_basketStatusId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_orderStatusId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "BasketStatuses");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Orders_orderStatusId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_basketStatusId",
                table: "Baskets");

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "basketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "orderDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "orderDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "orderDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "orderDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "orderStatusId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "basketStatusId",
                table: "Baskets");

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "basketId",
                keyValue: 1,
                column: "userId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "basketId",
                keyValue: 2,
                column: "userId",
                value: 4);
        }
    }
}
