// <auto-generated />
using System;
using GoogleForms.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoogleForms.DAL.Migrations
{
    [DbContext(typeof(GoogleFormsContext))]
    [Migration("20220918144545_asdsadadaa")]
    partial class asdsadadaa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppUserForm", b =>
                {
                    b.Property<int>("FormsId")
                        .HasColumnType("int");

                    b.Property<int>("appUsersId")
                        .HasColumnType("int");

                    b.HasKey("FormsId", "appUsersId");

                    b.HasIndex("appUsersId");

                    b.ToTable("AppUserForm");
                });

            modelBuilder.Entity("GoogleForms.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ChoiceRate")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsItLeastSelected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsItMostSelected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsItUserAnswer")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfChoose")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("answerType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9825),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 1,
                            answerType = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9827),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 1,
                            answerType = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9827),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 1,
                            answerType = 0
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9828),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 1,
                            answerType = 0
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9828),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 1,
                            answerType = 0
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9829),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 2,
                            answerType = 0
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9829),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 3,
                            answerType = 0
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9830),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 4,
                            answerType = 0
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9830),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 4,
                            answerType = 0
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9831),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 4,
                            answerType = 0
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9831),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 4,
                            answerType = 0
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9832),
                            Description = "Deneme Cevabı 1",
                            IsDeleted = false,
                            IsItLeastSelected = false,
                            IsItMostSelected = false,
                            IsItUserAnswer = false,
                            NumberOfChoose = 0,
                            QuestionId = 4,
                            answerType = 0
                        });
                });

            modelBuilder.Entity("GoogleForms.Entities.Form", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FormDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Forms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9630),
                            FormDescription = "Deneme Formu Açıklaması1",
                            FormTitle = "Deneme Formu Başlığı1",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9643),
                            FormDescription = "Deneme Formu Açıklaması2",
                            FormTitle = "Deneme Formu Başlığı2",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("GoogleForms.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("AverageAnswersValue")
                        .HasColumnType("float");

                    b.Property<double?>("AverageOfAllAnswers")
                        .HasColumnType("float");

                    b.Property<double?>("CorrectAnswerAverage")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAnswered")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUnique")
                        .HasColumnType("bit");

                    b.Property<double?>("MaxAnsweresValue")
                        .HasColumnType("float");

                    b.Property<double?>("MaxChoiceAnsweresValue")
                        .HasColumnType("float");

                    b.Property<double?>("MinAnsweresValue")
                        .HasColumnType("float");

                    b.Property<double?>("MinChoiceAnsweresValue")
                        .HasColumnType("float");

                    b.Property<int>("NumberOfAnswers")
                        .HasColumnType("int");

                    b.Property<string>("QuestionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.Property<double?>("WrongAnswerAverage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9751),
                            FormId = 1,
                            IsAnswered = false,
                            IsDeleted = false,
                            IsUnique = false,
                            NumberOfAnswers = 0,
                            QuestionTitle = "Deneme Sorusu1 ",
                            QuestionType = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9754),
                            FormId = 1,
                            IsAnswered = false,
                            IsDeleted = false,
                            IsUnique = false,
                            NumberOfAnswers = 0,
                            QuestionTitle = "Deneme Sorusu1 ",
                            QuestionType = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9755),
                            FormId = 2,
                            IsAnswered = false,
                            IsDeleted = false,
                            IsUnique = false,
                            NumberOfAnswers = 0,
                            QuestionTitle = "Deneme Sorusu1 ",
                            QuestionType = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 9, 18, 17, 45, 45, 411, DateTimeKind.Local).AddTicks(9756),
                            FormId = 2,
                            IsAnswered = false,
                            IsDeleted = false,
                            IsUnique = false,
                            NumberOfAnswers = 0,
                            QuestionTitle = "Deneme Sorusu1 ",
                            QuestionType = 3
                        });
                });

            modelBuilder.Entity("GoogleForms.Entities.UserAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsItTrueAnswer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfChoose")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("answerType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("UserAnswer");
                });

            modelBuilder.Entity("GoogleForms.Entities.UserEntities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("GoogleForms.Entities.UserEntities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AppUserForm", b =>
                {
                    b.HasOne("GoogleForms.Entities.Form", null)
                        .WithMany()
                        .HasForeignKey("FormsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoogleForms.Entities.UserEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("appUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoogleForms.Entities.Answer", b =>
                {
                    b.HasOne("GoogleForms.Entities.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("GoogleForms.Entities.Question", b =>
                {
                    b.HasOne("GoogleForms.Entities.Form", "Form")
                        .WithMany("Questions")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("GoogleForms.Entities.UserAnswer", b =>
                {
                    b.HasOne("GoogleForms.Entities.Question", "Question")
                        .WithMany("UserAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("GoogleForms.Entities.UserEntities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("GoogleForms.Entities.UserEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("GoogleForms.Entities.UserEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("GoogleForms.Entities.UserEntities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoogleForms.Entities.UserEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("GoogleForms.Entities.UserEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoogleForms.Entities.Form", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("GoogleForms.Entities.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("UserAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
