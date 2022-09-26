using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class dasdasdsadasdasdas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OpertionQuestion1Id",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpertionQuestion2Id",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 19, 22, 57, 875, DateTimeKind.Local).AddTicks(4863));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpertionQuestion1Id",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "OpertionQuestion2Id",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 22, 17, 22, 20, 688, DateTimeKind.Local).AddTicks(8723));
        }
    }
}
