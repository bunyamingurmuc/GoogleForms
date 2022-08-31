using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class deneme121 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "UserAnswer",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 14, 4, 53, 936, DateTimeKind.Local).AddTicks(7984));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "UserAnswer");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 26, 14, 48, 44, 609, DateTimeKind.Local).AddTicks(8426));
        }
    }
}
