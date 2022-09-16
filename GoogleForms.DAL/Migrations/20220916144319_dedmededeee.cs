using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    public partial class dedmededeee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserForm",
                columns: table => new
                {
                    FormsId = table.Column<int>(type: "int", nullable: false),
                    appUsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserForm", x => new { x.FormsId, x.appUsersId });
                    table.ForeignKey(
                        name: "FK_AppUserForm_AspNetUsers_appUsersId",
                        column: x => x.appUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserForm_Forms_FormsId",
                        column: x => x.FormsId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
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
                values: new object[] { 1, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1395), "Deneme Formu Açıklaması1", "Deneme Formu Başlığı1", false });

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "Id", "CreatedDate", "FormDescription", "FormTitle", "IsDeleted" },
                values: new object[] { 2, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1409), "Deneme Formu Açıklaması2", "Deneme Formu Başlığı2", false });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AverageAnswersValue", "AverageOfAllAnswers", "CorrectAnswerAverage", "CreatedDate", "FormId", "IsAnswered", "IsDeleted", "IsUnique", "MaxAnsweresValue", "MaxChoiceAnsweresValue", "MinAnsweresValue", "MinChoiceAnsweresValue", "NumberOfAnswers", "QuestionTitle", "QuestionType", "WrongAnswerAverage" },
                values: new object[,]
                {
                    { 1, null, null, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1545), 1, false, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 0, null },
                    { 2, null, null, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1548), 1, false, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 2, null },
                    { 3, null, null, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1549), 2, false, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 1, null },
                    { 4, null, null, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1550), 2, false, false, false, null, null, null, null, 0, "Deneme Sorusu1 ", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "ChoiceRate", "CreatedDate", "Description", "IsDeleted", "IsItLeastSelected", "IsItMostSelected", "IsItUserAnswer", "NumberOfChoose", "QuestionId", "answerType" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1602), "Deneme Cevabı 1", false, false, false, false, 0, 1, 0 },
                    { 2, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1603), "Deneme Cevabı 1", false, false, false, false, 0, 1, 0 },
                    { 3, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1603), "Deneme Cevabı 1", false, false, false, false, 0, 1, 0 },
                    { 4, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1604), "Deneme Cevabı 1", false, false, false, false, 0, 1, 0 },
                    { 5, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1604), "Deneme Cevabı 1", false, false, false, false, 0, 1, 0 },
                    { 6, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1605), "Deneme Cevabı 1", false, false, false, false, 0, 2, 0 },
                    { 7, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1605), "Deneme Cevabı 1", false, false, false, false, 0, 3, 0 },
                    { 8, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1606), "Deneme Cevabı 1", false, false, false, false, 0, 4, 0 },
                    { 9, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1607), "Deneme Cevabı 1", false, false, false, false, 0, 4, 0 },
                    { 10, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1607), "Deneme Cevabı 1", false, false, false, false, 0, 4, 0 },
                    { 11, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1608), "Deneme Cevabı 1", false, false, false, false, 0, 4, 0 },
                    { 12, null, new DateTime(2022, 9, 16, 17, 43, 19, 13, DateTimeKind.Local).AddTicks(1608), "Deneme Cevabı 1", false, false, false, false, 0, 4, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserForm_appUsersId",
                table: "AppUserForm",
                column: "appUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AppUserForm");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "UserAnswer");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}
