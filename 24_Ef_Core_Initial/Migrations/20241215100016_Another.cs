using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ef_Core_Initial.Migrations
{
    /// <inheritdoc />
    public partial class Another : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    ClubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClubDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.ClubId);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonCreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                });

            migrationBuilder.CreateTable(
                name: "MyStudents",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Soyisim = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FieldId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyStudents", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_MyStudents_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubStudent",
                columns: table => new
                {
                    ClubsClubId = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubStudent", x => new { x.ClubsClubId, x.StudentsStudentId });
                    table.ForeignKey(
                        name: "FK_ClubStudent_Clubs_ClubsClubId",
                        column: x => x.ClubsClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubStudent_MyStudents_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "MyStudents",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identities",
                columns: table => new
                {
                    IdentityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identities", x => x.IdentityId);
                    table.ForeignKey(
                        name: "FK_Identities_MyStudents_StudentId",
                        column: x => x.StudentId,
                        principalTable: "MyStudents",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentLessons",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLessons", x => new { x.StudentId, x.LessonId });
                    table.ForeignKey(
                        name: "FK_StudentLessons_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentLessons_MyStudents_StudentId",
                        column: x => x.StudentId,
                        principalTable: "MyStudents",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "ClubId", "ClubDescription", "ClubName", "CreateDate", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Yazılım çok keyifli", "Yazılım", new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6174), new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6189) },
                    { 2, "Kitap okumak çok keyifli", "Kitap", new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6191), new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6193) }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sayısal" },
                    { 2, "Eşit Ağırlık" },
                    { 3, "Sözel" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "CreateDate", "LessonCreateDate", "LessonName", "UpdateDate" },
                values: new object[] { 1, new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6516), new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6512), "Matematik", new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.InsertData(
                table: "MyStudents",
                columns: new[] { "StudentId", "Birthdate", "CreateDate", "FieldId", "Name", "Soyisim" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6460), 1, "Tarık", "Hamarat" },
                    { 2, new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6464), 2, "Ömer", "Şahin" },
                    { 3, new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6466), new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6468), 3, "Yusuf", "Ergin" },
                    { 4, new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6470), new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6471), 1, "Duhan", "Göksal" }
                });

            migrationBuilder.InsertData(
                table: "Identities",
                columns: new[] { "IdentityId", "CardNumber", "CreateDate", "StudentId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "e18341fa-d83e-4411-88a2-35b1710deaa1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "f9ab06e2-ea2c-4197-9d73-964ea63dfb0b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "b3af48c2-58af-45d4-8e76-feb592bebc29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "StudentLessons",
                columns: new[] { "LessonId", "StudentId", "CreateDate", "UpdateDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6554), new DateTime(2024, 12, 15, 13, 0, 15, 861, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.CreateIndex(
                name: "IX_ClubStudent_StudentsStudentId",
                table: "ClubStudent",
                column: "StudentsStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Identities_StudentId",
                table: "Identities",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyStudents_FieldId",
                table: "MyStudents",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLessons_LessonId",
                table: "StudentLessons",
                column: "LessonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubStudent");

            migrationBuilder.DropTable(
                name: "Identities");

            migrationBuilder.DropTable(
                name: "StudentLessons");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "MyStudents");

            migrationBuilder.DropTable(
                name: "Fields");
        }
    }
}
