using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class deneme1224 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAnswered",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 15, 45, 31, 167, DateTimeKind.Local).AddTicks(998));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAnswered",
                table: "Questions");

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
    }
}
