using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class deneme8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AverageAnswersValue",
                table: "Questions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AverageOfAllAnswers",
                table: "Questions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CorrectAnswerAverage",
                table: "Questions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaxAnsweresValue",
                table: "Questions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaxChoiceAnsweresValue",
                table: "Questions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MinAnsweresValue",
                table: "Questions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MinChoiceAnsweresValue",
                table: "Questions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfAnswers",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "WrongAnswerAverage",
                table: "Questions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsItTrueAnswer",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfChoose",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageAnswersValue",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AverageOfAllAnswers",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CorrectAnswerAverage",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "MaxAnsweresValue",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "MaxChoiceAnsweresValue",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "MinAnsweresValue",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "MinChoiceAnsweresValue",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "NumberOfAnswers",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "WrongAnswerAverage",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsItTrueAnswer",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "NumberOfChoose",
                table: "Answers");
        }
    }
}
