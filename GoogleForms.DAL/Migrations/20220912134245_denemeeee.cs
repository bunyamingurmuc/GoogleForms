using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class denemeeee : Migration
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
                    IsAnswered = table.Column<bool>(type: "bit", nullable: false),
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
                    IsItUserAnswer = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfChoose = table.Column<int>(type: "int", nullable: false),
                    ChoiceRate = table.Column<int>(type: "int", nullable: true),
                    IsItLeastSelected = table.Column<bool>(type: "bit", nullable: false),
                    IsItMostSelected = table.Column<bool>(type: "bit", nullable: false),
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
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
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
                values: new object[] { 1, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2683), "Deneme Formu Açıklaması1", "Deneme Formu Başlığı1", false });

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "Id", "CreatedDate", "FormDescription", "FormTitle", "IsDeleted" },
                values: new object[] { 2, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2704), "Deneme Formu Açıklaması2", "Deneme Formu Başlığı2", false });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AverageAnswersValue", "AverageOfAllAnswers", "CorrectAnswerAverage", "CreatedDate", "FormId", "IsAnswered", "IsDeleted", "IsRequired", "MaxAnsweresValue", "MaxChoiceAnsweresValue", "MinAnsweresValue", "MinChoiceAnsweresValue", "NumberOfAnswers", "QuestionTitle", "QuestionType", "WrongAnswerAverage" },
                values: new object[,]
                {
                    { 1, null, null, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2850), 1, false, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 0, null },
                    { 2, null, null, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2877), 1, false, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 2, null },
                    { 3, null, null, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2878), 2, false, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 1, null },
                    { 4, null, null, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2879), 2, false, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "ChoiceRate", "CreatedDate", "Description", "IsDeleted", "IsItLeastSelected", "IsItMostSelected", "IsItUserAnswer", "NumberOfChoose", "QuestionId", "answerType" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2976), "Deneme Cevabı 1", false, false, false, false, 0, 1, 0 },
                    { 2, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2977), "Deneme Cevabı 1", false, false, false, false, 0, 1, 0 },
                    { 3, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2977), "Deneme Cevabı 1", false, false, false, false, 0, 1, 0 },
                    { 4, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2978), "Deneme Cevabı 1", false, false, false, false, 0, 1, 0 },
                    { 5, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2979), "Deneme Cevabı 1", false, false, false, false, 0, 1, 0 },
                    { 6, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2979), "Deneme Cevabı 1", false, false, false, false, 0, 2, 0 },
                    { 7, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2980), "Deneme Cevabı 1", false, false, false, false, 0, 3, 0 },
                    { 8, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2980), "Deneme Cevabı 1", false, false, false, false, 0, 4, 0 },
                    { 9, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2981), "Deneme Cevabı 1", false, false, false, false, 0, 4, 0 },
                    { 10, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2982), "Deneme Cevabı 1", false, false, false, false, 0, 4, 0 },
                    { 11, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2982), "Deneme Cevabı 1", false, false, false, false, 0, 4, 0 },
                    { 12, null, new DateTime(2022, 9, 12, 16, 42, 44, 869, DateTimeKind.Local).AddTicks(2983), "Deneme Cevabı 1", false, false, false, false, 0, 4, 0 }
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
