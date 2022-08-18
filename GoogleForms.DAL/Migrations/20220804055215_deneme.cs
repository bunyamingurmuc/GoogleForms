using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    QuestionType = table.Column<int>(type: "int", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "Id", "CreatedDate", "FormDescription", "FormTitle", "IsDeleted" },
                values: new object[] { 1, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1680), "Deneme Formu Açıklaması1", "Deneme Formu Başlığı2", false });

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "Id", "CreatedDate", "FormDescription", "FormTitle", "IsDeleted" },
                values: new object[] { 2, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1690), "Deneme Formu Açıklaması2", "Deneme Formu Başlığı2", false });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedDate", "FormId", "IsDeleted", "IsRequired", "QuestionTitle", "QuestionType" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1844), 1, false, false, "Deneme Sorusu1 ", 0 },
                    { 2, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1847), 1, false, false, "Deneme Sorusu1 ", 2 },
                    { 3, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1848), 2, false, false, "Deneme Sorusu1 ", 1 },
                    { 4, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1849), 2, false, false, "Deneme Sorusu1 ", 3 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "QuestionId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1910), "Deneme Cevabı 1", false, 1 },
                    { 2, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1911), "Deneme Cevabı 1", false, 1 },
                    { 3, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1912), "Deneme Cevabı 1", false, 1 },
                    { 4, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1913), "Deneme Cevabı 1", false, 1 },
                    { 5, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1913), "Deneme Cevabı 1", false, 1 },
                    { 6, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1914), "Deneme Cevabı 1", false, 2 },
                    { 7, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1915), "Deneme Cevabı 1", false, 3 },
                    { 8, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1915), "Deneme Cevabı 1", false, 4 },
                    { 9, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1916), "Deneme Cevabı 1", false, 4 },
                    { 10, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1917), "Deneme Cevabı 1", false, 4 },
                    { 11, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1917), "Deneme Cevabı 1", false, 4 },
                    { 12, new DateTime(2022, 8, 4, 8, 52, 14, 867, DateTimeKind.Local).AddTicks(1962), "Deneme Cevabı 1", false, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_FormId",
                table: "Questions",
                column: "FormId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}
