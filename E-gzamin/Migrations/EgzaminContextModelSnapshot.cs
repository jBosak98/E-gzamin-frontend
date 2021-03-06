﻿// <auto-generated />
using System;
using E_gzamin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace E_gzamin.Migrations
{
    [DbContext(typeof(EgzaminContext))]
    partial class EgzaminContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("E_gzamin.Models.Designate", b =>
                {
                    b.Property<int>("TestTemplateId")
                        .HasColumnType("integer");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("PassReq")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Time")
                        .HasColumnType("integer");

                    b.HasKey("TestTemplateId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("Designate");
                });

            modelBuilder.Entity("E_gzamin.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ClosedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("GroupCode")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("OpenedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("RemovedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("E_gzamin.Models.GroupUser", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupUser");
                });

            modelBuilder.Entity("E_gzamin.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("RemovedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("E_gzamin.Models.QuestionTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("QuestionsCount")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("RemovedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TestTemplateId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TestTemplateId");

                    b.ToTable("QuestionTemplate");
                });

            modelBuilder.Entity("E_gzamin.Models.QuestionTemplateQuestion", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<int>("QuestionTemplateId")
                        .HasColumnType("integer");

                    b.HasKey("QuestionId", "QuestionTemplateId");

                    b.HasIndex("QuestionTemplateId");

                    b.ToTable("QuestionTemplateQuestion");
                });

            modelBuilder.Entity("E_gzamin.Models.QuestionTestResult", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<int>("TestResultId")
                        .HasColumnType("integer");

                    b.HasKey("QuestionId", "TestResultId");

                    b.HasIndex("TestResultId");

                    b.ToTable("QuestionTestResult");
                });

            modelBuilder.Entity("E_gzamin.Models.QuestionTestTemplate", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<int>("TestTemplateId")
                        .HasColumnType("integer");

                    b.HasKey("QuestionId", "TestTemplateId");

                    b.HasIndex("TestTemplateId");

                    b.ToTable("QuestionTestTemplate");
                });

            modelBuilder.Entity("E_gzamin.Models.TestResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CompletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("FinishedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("MaxPoints")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("RemovedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Result")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TestTemplateId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<bool>("isPassed")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("TestTemplateId");

                    b.HasIndex("UserId");

                    b.ToTable("TestResult");
                });

            modelBuilder.Entity("E_gzamin.Models.TestTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("RemovedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("TestTemplate");
                });

            modelBuilder.Entity("E_gzamin.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("HashedPassword")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RemovedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Salt")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("E_gzamin.Models.Designate", b =>
                {
                    b.HasOne("E_gzamin.Models.Group", "Group")
                        .WithMany("Designates")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_gzamin.Models.TestTemplate", "TestTemplate")
                        .WithMany("Designates")
                        .HasForeignKey("TestTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_gzamin.Models.Group", b =>
                {
                    b.HasOne("E_gzamin.Models.User", "Owner")
                        .WithMany("GroupsOwned")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_gzamin.Models.GroupUser", b =>
                {
                    b.HasOne("E_gzamin.Models.Group", "Group")
                        .WithMany("GroupUsers")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_gzamin.Models.User", "User")
                        .WithMany("UserGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_gzamin.Models.QuestionTemplate", b =>
                {
                    b.HasOne("E_gzamin.Models.TestTemplate", "TestTemplate")
                        .WithMany("QuestionTemplates")
                        .HasForeignKey("TestTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_gzamin.Models.QuestionTemplateQuestion", b =>
                {
                    b.HasOne("E_gzamin.Models.Question", "Question")
                        .WithMany("QuestionTemplateQuestions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_gzamin.Models.QuestionTemplate", "QuestionTemplate")
                        .WithMany("QuestionTemplateQuestions")
                        .HasForeignKey("QuestionTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_gzamin.Models.QuestionTestResult", b =>
                {
                    b.HasOne("E_gzamin.Models.Question", "Question")
                        .WithMany("TestResults")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_gzamin.Models.TestResult", "TestResult")
                        .WithMany("QuestionTestResults")
                        .HasForeignKey("TestResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_gzamin.Models.QuestionTestTemplate", b =>
                {
                    b.HasOne("E_gzamin.Models.Question", "Question")
                        .WithMany("QuestionTestTemplates")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_gzamin.Models.TestTemplate", "TestTemplate")
                        .WithMany("QuestionTestTemplates")
                        .HasForeignKey("TestTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_gzamin.Models.TestResult", b =>
                {
                    b.HasOne("E_gzamin.Models.TestTemplate", "TestTemplate")
                        .WithMany("TestResults")
                        .HasForeignKey("TestTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_gzamin.Models.User", "User")
                        .WithMany("TestResults")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_gzamin.Models.TestTemplate", b =>
                {
                    b.HasOne("E_gzamin.Models.User", "Owner")
                        .WithMany("TestTemplates")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
