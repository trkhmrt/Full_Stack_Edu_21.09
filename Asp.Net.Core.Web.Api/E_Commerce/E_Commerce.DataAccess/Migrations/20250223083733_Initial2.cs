using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_categogryId",
                table: "SubCategories");

            migrationBuilder.RenameColumn(
                name: "categogryId",
                table: "SubCategories",
                newName: "categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_categogryId",
                table: "SubCategories",
                newName: "IX_SubCategories_categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_categoryId",
                table: "SubCategories",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_categoryId",
                table: "SubCategories");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "SubCategories",
                newName: "categogryId");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_categoryId",
                table: "SubCategories",
                newName: "IX_SubCategories_categogryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_categogryId",
                table: "SubCategories",
                column: "categogryId",
                principalTable: "Categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
