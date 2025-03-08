using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PaymentUserRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 1,
                column: "orderDate",
                value: new DateTime(2025, 3, 8, 11, 38, 22, 200, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 2,
                column: "orderDate",
                value: new DateTime(2025, 3, 8, 11, 38, 22, 200, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.CreateIndex(
                name: "IX_Payments_userId",
                table: "Payments",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_userId",
                table: "Payments",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_userId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_userId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 1,
                column: "orderDate",
                value: new DateTime(2025, 3, 8, 9, 55, 52, 613, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "orderId",
                keyValue: 2,
                column: "orderDate",
                value: new DateTime(2025, 3, 8, 9, 55, 52, 613, DateTimeKind.Local).AddTicks(2810));
        }
    }
}
