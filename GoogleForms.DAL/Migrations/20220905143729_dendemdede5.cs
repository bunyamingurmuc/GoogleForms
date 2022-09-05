using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class dendemdede5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ChoiceRate",
                table: "Answers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsItLeastSelected",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsItMostSelected",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 17, 37, 29, 345, DateTimeKind.Local).AddTicks(8941));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChoiceRate",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "IsItLeastSelected",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "IsItMostSelected",
                table: "Answers");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 15, 58, 25, 192, DateTimeKind.Local).AddTicks(589));
        }
    }
}
