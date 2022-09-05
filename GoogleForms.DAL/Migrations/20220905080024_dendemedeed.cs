using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class dendemedeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsItTrueAnswer",
                table: "Answers",
                newName: "IsItUserAnswer");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 11, 0, 24, 534, DateTimeKind.Local).AddTicks(5006));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsItUserAnswer",
                table: "Answers",
                newName: "IsItTrueAnswer");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 31, 18, 15, 12, 489, DateTimeKind.Local).AddTicks(5518));
        }
    }
}
