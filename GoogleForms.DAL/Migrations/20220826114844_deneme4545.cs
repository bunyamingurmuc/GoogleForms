using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class deneme4545 : Migration
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
                    AverageAnswersValue = table.Column<double>(type: "float", nullable: true),
                    AverageOfAllAnswers = table.Column<double>(type: "float", nullable: true),
                    MinAnsweresValue = table.Column<double>(type: "float", nullable: true),
                    MaxAnsweresValue = table.Column<double>(type: "float", nullable: true),
                    CorrectAnswerAverage = table.Column<double>(type: "float", nullable: true),
                    WrongAnswerAverage = table.Column<double>(type: "float", nullable: true),
                    NumberOfAnswers = table.Column<int>(type: "int", nullable: false),
                    MinChoiceAnsweresValue = table.Column<double>(type: "float", nullable: true),
                    MaxChoiceAnsweresValue = table.Column<double>(type: "float", nullable: true),
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
                    answerType = table.Column<int>(type: "int", nullable: false),
                    IsItTrueAnswer = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfChoose = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "UserAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answerType = table.Column<int>(type: "int", nullable: false),
                    IsItTrueAnswer = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfChoose = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnswer_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "Id", "CreatedDate", "FormDescription", "FormTitle", "IsDeleted" },
                values: new object[] { 1, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8192), "Deneme Formu Açıklaması1", "Deneme Formu Başlığı2", false });

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "Id", "CreatedDate", "FormDescription", "FormTitle", "IsDeleted" },
                values: new object[] { 2, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8204), "Deneme Formu Açıklaması2", "Deneme Formu Başlığı2", false });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AverageAnswersValue", "AverageOfAllAnswers", "CorrectAnswerAverage", "CreatedDate", "FormId", "IsDeleted", "IsRequired", "MaxAnsweresValue", "MaxChoiceAnsweresValue", "MinAnsweresValue", "MinChoiceAnsweresValue", "NumberOfAnswers", "QuestionTitle", "QuestionType", "WrongAnswerAverage" },
                values: new object[,]
                {
                    { 1, null, null, null, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8424), 1, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 0, null },
                    { 2, null, null, null, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8425), 1, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 2, null },
                    { 3, null, null, null, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8426), 2, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 1, null },
                    { 4, null, null, null, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8426), 2, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "IsItTrueAnswer", "NumberOfChoose", "QuestionId", "answerType" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8507), "Deneme Cevabı 1", false, false, 0, 1, 0 },
                    { 2, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8509), "Deneme Cevabı 1", false, false, 0, 1, 0 },
                    { 3, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8510), "Deneme Cevabı 1", false, false, 0, 1, 0 },
                    { 4, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8510), "Deneme Cevabı 1", false, false, 0, 1, 0 },
                    { 5, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8511), "Deneme Cevabı 1", false, false, 0, 1, 0 },
                    { 6, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8511), "Deneme Cevabı 1", false, false, 0, 2, 0 },
                    { 7, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8512), "Deneme Cevabı 1", false, false, 0, 3, 0 },
                    { 8, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8512), "Deneme Cevabı 1", false, false, 0, 4, 0 },
                    { 9, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8513), "Deneme Cevabı 1", false, false, 0, 4, 0 },
                    { 10, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8513), "Deneme Cevabı 1", false, false, 0, 4, 0 },
                    { 11, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8514), "Deneme Cevabı 1", false, false, 0, 4, 0 },
                    { 12, new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8515), "Deneme Cevabı 1", false, false, 0, 4, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_FormId",
                table: "Questions",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_QuestionId",
                table: "UserAnswer",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "UserAnswer");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}
