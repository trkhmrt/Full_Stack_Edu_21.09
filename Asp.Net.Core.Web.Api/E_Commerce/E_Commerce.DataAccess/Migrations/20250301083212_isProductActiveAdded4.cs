using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Commerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class isProductActiveAdded4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isProductActiv",
                table: "Products",
                newName: "isProductActive");

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
                table: "Baskets",
                columns: new[] { "basketId", "userId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 4 }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BasketDetails",
                keyColumn: "basketDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BasketDetails",
                keyColumn: "basketDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BasketDetails",
                keyColumn: "basketDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BasketDetails",
                keyColumn: "basketDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "categoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "subCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "subCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "subCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "basketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "basketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "roleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "roleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "roleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "subCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "subCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "subCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "categoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "categoryId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "isProductActive",
                table: "Products",
                newName: "isProductActiv");
        }
    }
}
