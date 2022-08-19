using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class deneme7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "Id", "CreatedDate", "FormDescription", "FormTitle", "IsDeleted" },
                values: new object[] { 1, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(2936), "Deneme Formu Açıklaması1", "Deneme Formu Başlığı2", false });

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "Id", "CreatedDate", "FormDescription", "FormTitle", "IsDeleted" },
                values: new object[] { 2, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(2947), "Deneme Formu Açıklaması2", "Deneme Formu Başlığı2", false });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedDate", "FormId", "IsDeleted", "IsRequired", "QuestionTitle", "QuestionType" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3092), 1, false, false, "Deneme Sorusu1 ", 0 },
                    { 2, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3095), 1, false, false, "Deneme Sorusu1 ", 2 },
                    { 3, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3096), 2, false, false, "Deneme Sorusu1 ", 1 },
                    { 4, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3096), 2, false, false, "Deneme Sorusu1 ", 3 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "QuestionId", "answerType" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3151), "Deneme Cevabı 1", false, 1, 0 },
                    { 2, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3154), "Deneme Cevabı 1", false, 1, 0 },
                    { 3, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3155), "Deneme Cevabı 1", false, 1, 0 },
                    { 4, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3155), "Deneme Cevabı 1", false, 1, 0 },
                    { 5, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3156), "Deneme Cevabı 1", false, 1, 0 },
                    { 6, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3218), "Deneme Cevabı 1", false, 2, 0 },
                    { 7, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3219), "Deneme Cevabı 1", false, 3, 0 },
                    { 8, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3219), "Deneme Cevabı 1", false, 4, 0 },
                    { 9, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3220), "Deneme Cevabı 1", false, 4, 0 },
                    { 10, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3221), "Deneme Cevabı 1", false, 4, 0 },
                    { 11, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3222), "Deneme Cevabı 1", false, 4, 0 },
                    { 12, new DateTime(2022, 8, 19, 9, 10, 38, 751, DateTimeKind.Local).AddTicks(3223), "Deneme Cevabı 1", false, 4, 0 }
                });
        }
    }
}
