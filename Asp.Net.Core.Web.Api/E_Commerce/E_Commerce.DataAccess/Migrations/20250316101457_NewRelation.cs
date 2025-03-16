using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Commerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
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

            migrationBuilder.CreateTable(
                name: "PaymentStatuses",
                columns: table => new
                {
                    paymentStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatuses", x => x.paymentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    roleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    subCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.subCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    roleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customerId);
                    table.ForeignKey(
                        name: "FK_Customers_Roles_roleId",
                        column: x => x.roleId,
                        principalTable: "Roles",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false),
                    roleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.userId, x.roleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_roleId",
                        column: x => x.roleId,
                        principalTable: "Roles",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productUnitPrice = table.Column<int>(type: "int", nullable: false),
                    isProductActive = table.Column<bool>(type: "bit", nullable: false),
                    subCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "subCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    basketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    basketStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.basketId);
                    table.ForeignKey(
                        name: "FK_Baskets_BasketStatuses_basketStatusId",
                        column: x => x.basketStatusId,
                        principalTable: "BasketStatuses",
                        principalColumn: "basketStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Baskets_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "customerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BasketDetails",
                columns: table => new
                {
                    basketDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    basketId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false),
                    basket_quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketDetails", x => x.basketDetailId);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Baskets_basketId",
                        column: x => x.basketId,
                        principalTable: "Baskets",
                        principalColumn: "basketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    orderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    totalAmount = table.Column<int>(type: "int", nullable: false),
                    basketId = table.Column<int>(type: "int", nullable: false),
                    orderStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_Orders_Baskets_basketId",
                        column: x => x.basketId,
                        principalTable: "Baskets",
                        principalColumn: "basketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "customerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_orderStatusId",
                        column: x => x.orderStatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "orderStatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    paymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    basketId = table.Column<int>(type: "int", nullable: false),
                    totalQuantity = table.Column<int>(type: "int", nullable: false),
                    totalAmount = table.Column<int>(type: "int", nullable: false),
                    paymentStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.paymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Baskets_basketId",
                        column: x => x.basketId,
                        principalTable: "Baskets",
                        principalColumn: "basketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "customerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentStatuses_paymentStatusId",
                        column: x => x.paymentStatusId,
                        principalTable: "PaymentStatuses",
                        principalColumn: "paymentStatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    orderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<int>(type: "int", nullable: false),
                    orderId = table.Column<int>(type: "int", nullable: false),
                    order_product_quantity = table.Column<int>(type: "int", nullable: false),
                    order_product_totalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.orderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BasketStatuses",
                columns: new[] { "basketStatusId", "basketStatusName" },
                values: new object[,]
                {
                    { 1, "Sepet Aktif" },
                    { 2, "Sepet İptal" },
                    { 3, "Sepet Ödemeye Hazır" },
                    { 4, "Sepet Siparişe İletildi" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryDescription", "categoryName" },
                values: new object[,]
                {
                    { 1, "Kılık Kıyafet Ayakkabı Giyim", "giyim" },
                    { 2, "Elektrik Elektronik İhtiyaçlar", "elektronik" },
                    { 3, "Gıda İhtiyaçları", "gıda" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "orderStatusId", "orderStatusName" },
                values: new object[,]
                {
                    { 1, "Sipariş Aktif" },
                    { 2, "Sipariş İptal" },
                    { 3, "Sipariş Kargoya Verildi" },
                    { 4, "Sipariş Tamamlandı" }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatuses",
                columns: new[] { "paymentStatusId", "paymentStatusName" },
                values: new object[,]
                {
                    { 1, "Ödendi" },
                    { 2, "İade edildi" },
                    { 3, "İptal edildi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { 1, "admin" },
                    { 2, "customer" },
                    { 3, "IT" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "email", "firstName", "password", "userName" },
                values: new object[,]
                {
                    { 1, "trk@trk.com", "tarik", "123456", "trk" },
                    { 2, "ysf@ysf.com", "yusuf", "123456", "ysf" },
                    { 3, "tna@tna.com", "tuna", "123456", "tna" },
                    { 4, "dhn@dhn.com", "duhan", "123456", "dhn" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "customerId", "customerAddress", "customerEmail", "customerFirstName", "customerLastName", "customerPassword", "customerPhoneNumber", "customerUserName", "roleId" },
                values: new object[,]
                {
                    { 1, "123 Main Street", "trk@gmail.com", "tarik", "hamarat", "123456", "05537696362", "trkhmrt", 2 },
                    { 2, "123 Main Street", "ysf@gmail.com", "yusuf", "ergin", "123456", "05537696362", "yusufergin", 2 },
                    { 3, "123 Main Street", "duhan@gmail.com", "duhan", "duhan", "123456", "05537696362", "duhanduhan", 2 },
                    { 4, "123 Main Street", "tuna@gmail.com", "tuna", "genç", "123456", "05537696362", "tunagenc", 2 },
                    { 5, "123 Main Street", "alper@gmail.com", "alper", "alpertyus", "123456", "05537696362", "alpertyus", 2 }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "subCategoryId", "categoryId", "subCategoryDescription", "subCategoryName" },
                values: new object[,]
                {
                    { 1, 1, "Alt giyim ürünleri", "alt giyim" },
                    { 2, 1, "üst giyim ürünleri", "üst giyim" },
                    { 3, 1, "İç giyim ürünleri", "İç giyim" },
                    { 4, 2, "Android Akıllı Cihazlar", "Akıllı Telefon" },
                    { 5, 2, "Oyun Konsol ürünleri", "Oyun Konslu" },
                    { 6, 2, "Televizyon ürünleri", "Televizyon" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "basketId", "basketStatusId", "customerId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 2 },
                    { 3, 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "isProductActive", "productDescription", "productName", "productUnitPrice", "subCategoryId" },
                values: new object[,]
                {
                    { 1, true, "Ps5 Oyun Konsolu", "Playstation 5", 10000, 5 },
                    { 2, true, "Xbox Oyun Konsolu", "Xbox", 12000, 5 },
                    { 3, true, "Kışlık Su Geçirmez Bot", "Bot", 2000, 1 },
                    { 4, true, "Suya dayanıklı Çizme", "Çizme", 4500, 1 },
                    { 5, true, "Ekoseli Gömlek", "Gömlek", 600, 2 },
                    { 6, true, "Boğazlı Kazak", "Kazak", 670, 2 }
                });

            migrationBuilder.InsertData(
                table: "BasketDetails",
                columns: new[] { "basketDetailId", "basketId", "basket_quantity", "productId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 1, 2 },
                    { 3, 2, 1, 3 },
                    { 4, 2, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "orderId", "basketId", "customerId", "orderDate", "orderStatusId", "totalAmount" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2025, 3, 16, 13, 14, 57, 308, DateTimeKind.Local).AddTicks(4720), 3, 400 },
                    { 2, 2, 4, new DateTime(2025, 3, 16, 13, 14, 57, 308, DateTimeKind.Local).AddTicks(4750), 3, 850 }
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
                name: "IX_BasketDetails_basketId",
                table: "BasketDetails",
                column: "basketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_productId",
                table: "BasketDetails",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_basketStatusId",
                table: "Baskets",
                column: "basketStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_customerId",
                table: "Baskets",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_roleId",
                table: "Customers",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_orderId",
                table: "OrderDetails",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_productId",
                table: "OrderDetails",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_basketId",
                table: "Orders",
                column: "basketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customerId",
                table: "Orders",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_orderStatusId",
                table: "Orders",
                column: "orderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_basketId",
                table: "Payments",
                column: "basketId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_customerId",
                table: "Payments",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_paymentStatusId",
                table: "Payments",
                column: "paymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_subCategoryId",
                table: "Products",
                column: "subCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_categoryId",
                table: "SubCategories",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_roleId",
                table: "UserRoles",
                column: "roleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketDetails");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PaymentStatuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "BasketStatuses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
